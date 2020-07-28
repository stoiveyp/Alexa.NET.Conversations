using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.Conversations.Test
{
    public static class Utility
    {
        private const string ExamplesPath = "Examples";

        public static Task<HttpResponseMessage> AsTask(this HttpResponseMessage message)
        {
            return Task.FromResult(message);
        }
        public static bool CompareJson(object actual, string expectedFile, params string[] exclude)
        {
            var actualJObject = JObject.FromObject(actual);
            var expected = File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
            var expectedJObject = JObject.Parse(expected);

            foreach (var item in exclude)
            {
                RemoveFrom(actualJObject, item);
                RemoveFrom(expectedJObject, item);
            }

            return JToken.DeepEquals(expectedJObject, actualJObject);

        }

        private static void RemoveFrom(JObject exclude, string item)
        {
            if (exclude.ContainsKey(item))
            {
                exclude.Remove(item);
            }

            foreach (var prop in exclude.Properties().Where(p => p.Value is JObject).Select(p => p.Value)
                .Cast<JObject>())
            {
                RemoveFrom(prop, item);
            }

            foreach (var prop in exclude.Properties().Where(p => p.Value is JArray).Select(p => p.Value).Cast<JArray>().SelectMany(a => a.Children())
                .Where(c => c.Type == JTokenType.Object).Cast<JObject>())
            {
                RemoveFrom(prop, item);
            }
        }

        public static T ExampleFileContent<T>(string expectedFile)
        {
            using (var reader = new JsonTextReader(new StringReader(ExampleFileContent(expectedFile))))
            {
                return new JsonSerializer().Deserialize<T>(reader);
            }
        }

        public static string ExampleFileContent(string expectedFile)
        {
            return File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
        }

        public static void AssertJson<T>(string fileName, params string[] exclude)
        {
            var actual = ExampleFileContent<T>(fileName);
            Assert.True(CompareJson(actual, fileName, exclude));
        }
    }
}

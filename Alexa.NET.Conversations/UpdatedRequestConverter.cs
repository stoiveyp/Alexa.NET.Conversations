using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.Conversations
{
    public class UpdatedRequestConverter : JsonConverter<UpdatedRequest>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, UpdatedRequest value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override UpdatedRequest ReadJson(JsonReader reader, Type objectType, UpdatedRequest existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var requestType = jObject.Value<string>("type");

            if (requestType == IntentRequest.RequestType)
            {
                existingValue = new IntentRequest();
            }
            else
            {
                existingValue = new DialogInputRequest();
            }

            serializer.Populate(jObject.CreateReader(), existingValue);
            return existingValue;
        }
    }
}
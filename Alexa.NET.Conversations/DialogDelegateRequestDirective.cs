using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class DialogDelegateRequestDirective:IDirective
    {
        private const string DirectiveType = "Dialog.DelegateRequest";

        public static void AddSupport()
        {
            DirectiveConverter.TypeFactories.Add(DirectiveType, () => new DialogDelegateRequestDirective());
        }
        public string Type => DirectiveType;

        [JsonProperty("target",NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        [JsonProperty("updatedInput",NullValueHandling = NullValueHandling.Ignore)]
        public object UpdatedInput { get; set; }
    }
}

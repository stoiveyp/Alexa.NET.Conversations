using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class IntentRequest : UpdatedRequest
    {
        public const string RequestType = "IntentRequest";

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => RequestType;

        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatedRequestData Input { get; set; }

    }
}
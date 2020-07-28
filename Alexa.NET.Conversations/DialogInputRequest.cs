using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class DialogInputRequest : UpdatedRequest
    {
        public const string RequestType = "Dialog.InputRequest";

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public override string Type => RequestType;

        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatedRequestData Input { get; set; }
    }
}
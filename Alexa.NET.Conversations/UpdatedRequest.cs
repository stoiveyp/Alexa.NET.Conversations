using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    [JsonConverter(typeof(UpdatedRequestConverter))]
    public abstract class UpdatedRequest
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public abstract string Type { get; }
    }
}
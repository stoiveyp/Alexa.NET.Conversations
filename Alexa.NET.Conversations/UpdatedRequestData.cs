using System.Collections.Generic;
using Alexa.NET.Request;
using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class UpdatedRequestData
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("slots", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Slot> Slots { get; set; }
    }
}
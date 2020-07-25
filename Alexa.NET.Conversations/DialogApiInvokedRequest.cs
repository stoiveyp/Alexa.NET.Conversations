using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class DialogApiInvokedRequest:Request.Type.Request
    {
        public static void AddToRequestConverter()
        {
            RequestConverter.RequestConverters.Add(new DialogApiRequestConverter());
        }

        [JsonProperty("apiRequest")]
        public ApiRequest ApiRequest { get; set; }
    }

    public class ApiRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("arguments",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> Arguments { get; set; }

        [JsonProperty("slots",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,SlotValue> Slots { get; set; }
    }
}

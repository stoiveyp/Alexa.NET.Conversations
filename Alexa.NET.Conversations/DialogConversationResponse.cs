using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Response;
using Newtonsoft.Json;

namespace Alexa.NET.Conversations
{
    public class DialogConversationResponse:ResponseBody
    {
        [JsonProperty("apiResponse",NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,object> ApiResponse { get; set; }
    }
}

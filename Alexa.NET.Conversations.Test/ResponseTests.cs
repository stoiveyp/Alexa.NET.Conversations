using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alexa.NET.Conversations.Test
{
    public class ResponseTests
    {
        [Fact]
        public void DialogResponse()
        {
            Utility.AssertJson<DialogConversationResponse>("ApiResponse.json", "shouldEndSession");
        }
    }
}

using System;
using Xunit;

namespace Alexa.NET.Conversations.Test
{
    public class RequestTests
    {
        [Fact]
        public void DialogApiInvokedRequest()
        {
            Conversations.DialogApiInvokedRequest.AddToRequestConverter();
            Utility.AssertJson<DialogApiInvokedRequest>("DialogApiInvoked.json", "locale", "timestamp", "requestId");
        }
    }
}

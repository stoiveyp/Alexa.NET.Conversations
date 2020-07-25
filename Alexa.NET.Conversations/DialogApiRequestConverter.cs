using Alexa.NET.Request.Type;

namespace Alexa.NET.Conversations
{
    public class DialogApiRequestConverter : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == "Dialog.API.Invoked";
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new DialogApiInvokedRequest();
        }
    }
}
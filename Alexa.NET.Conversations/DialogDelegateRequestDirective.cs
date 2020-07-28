using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Conversations
{
    public class DialogDelegateRequestDirective : IDirective
    {
        private const string DirectiveType = "Dialog.DelegateRequest";

        public static void AddSupport()
        {
            DirectiveConverter.TypeFactories.Add(DirectiveType, () => new DialogDelegateRequestDirective());
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type => DirectiveType;

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore),
        JsonConverter(typeof(StringEnumConverter))]
        public DialogManager Target { get; set; }

        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public DelegatePeriod Period { get; set; }

        [JsonProperty("updatedRequest", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatedRequest UpdatedRequest { get; set; }

        public static DialogDelegateRequestDirective ToConversations(DelegatePeriod period, DialogInputRequest updatedRequest = null) => new DialogDelegateRequestDirective
        {
            Target = DialogManager.Conversations,
            Period = period,
            UpdatedRequest = updatedRequest
        };

        public static DialogDelegateRequestDirective ToSkill(DelegatePeriod period, IntentRequest updatedRequest = null) => new DialogDelegateRequestDirective
        {
            Target = DialogManager.Skill,
            Period = period,
            UpdatedRequest = updatedRequest
        };
    }
}

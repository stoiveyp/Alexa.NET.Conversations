using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.Conversations
{
    public class DelegatePeriod
    {
        public static DelegatePeriod NextTurn => new DelegatePeriod {Until = DelegatePeriodUntil.NextTurn};
        public static DelegatePeriod ExplicitReturn => new DelegatePeriod {Until = DelegatePeriodUntil.ExplicitReturn};

        [JsonProperty("until"),
         JsonConverter(typeof(StringEnumConverter))]
        public DelegatePeriodUntil Until { get; set; }
    }
}
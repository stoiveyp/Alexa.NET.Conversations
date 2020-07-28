using System.Runtime.Serialization;

namespace Alexa.NET.Conversations
{
    public enum DelegatePeriodUntil
    {
        [EnumMember(Value="EXPLICIT_RETURN")]
        ExplicitReturn,
        [EnumMember(Value="NEXT_TURN")]
        NextTurn
    }
}
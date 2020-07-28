using System.Runtime.Serialization;

namespace Alexa.NET.Conversations
{
    public enum DialogManager
    {
        [EnumMember(Value="AMAZON.Conversations")]
        Conversations,
        [EnumMember(Value="skill")]
        Skill
    }
}
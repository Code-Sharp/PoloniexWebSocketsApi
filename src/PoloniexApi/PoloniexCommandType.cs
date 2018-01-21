using System.Runtime.Serialization;

namespace PoloniexApi
{
    public enum PoloniexCommandType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "unsubscribe")]
        Unsubscribe,
        [EnumMember(Value = "subscribe")]
        Subscribe
    }
}
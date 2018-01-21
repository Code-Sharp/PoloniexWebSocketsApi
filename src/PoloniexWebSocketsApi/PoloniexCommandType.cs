using System.Runtime.Serialization;

namespace PoloniexWebSocketsApi
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
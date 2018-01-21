using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PoloniexWebSocketsApi
{
    [DataContract]
    public class PoloniexCommand
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "command")]
        public PoloniexCommandType Command { get; set; }

        [DataMember(Name = "channel")]
        public int Channel { get; set; }

        [DataMember(Name = "id")]
        public int? Id { get; set; }

        [DataMember(Name = "params")]
        public object Params { get; set; }
    }
}
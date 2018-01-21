using Newtonsoft.Json;

namespace PoloniexWebSocketsApi
{
    public delegate void MessageArrivedDelegate(JsonSerializer serializer, object message);
}
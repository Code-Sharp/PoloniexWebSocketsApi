using Newtonsoft.Json;

namespace PoloniexApi
{
    public delegate void MessageArrivedDelegate(JsonSerializer serializer, object message);
}
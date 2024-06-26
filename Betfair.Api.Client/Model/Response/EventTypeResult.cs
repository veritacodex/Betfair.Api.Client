using System.Text;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class EventTypeResult
{
    [JsonProperty(PropertyName = "eventType")]
    public EventType EventType { get; set; }

    [JsonProperty(PropertyName = "marketCount")]
    public int MarketCount { get; set; }

    public override string ToString()
    {
        return new StringBuilder().AppendFormat("{0}", "EventTypeResult")
                    .AppendFormat(" : {0}", EventType)
                    .AppendFormat(" : MarketCount={0}", MarketCount)
                    .ToString();
    }
}

using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class MarketType
{
    [JsonProperty(PropertyName = "marketType")]
    public string Type { get; set; }

    [JsonProperty(PropertyName = "marketCount")]
    public int MarketCount { get; set; }
}
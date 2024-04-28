using Betfair.Api.Client.Model.Response;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Request;

public class PlaceInstruction
{
    [JsonProperty(PropertyName = "orderType")]
    public string OrderType { get; set; }

    [JsonProperty(PropertyName = "selectionId")]
    public string SelectionId { get; set; }

    [JsonProperty(PropertyName = "handicap")]
    public string Handicap { get; set; }

    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    [JsonProperty(PropertyName = "limitOrder")]
    public LimitOrder LimitOrder { get; set; }

    [JsonProperty(PropertyName = "limitOnCloseOrder")]
    public LimitOnCloseOrder LimitOnCloseOrder { get; set; }

    [JsonProperty(PropertyName = "marketOnCloseOrder")]
    public MarketOnCloseOrder MarketOnCloseOrder { get; set; }
}
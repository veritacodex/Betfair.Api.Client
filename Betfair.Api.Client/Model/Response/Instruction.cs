using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class Instruction
{
    [JsonProperty("selectionId")]
    public string SelectionId { get; set; }

    [JsonProperty("handicap")]
    public string Handicap { get; set; }

    [JsonProperty("limitOrder")]
    public LimitOrder LimitOrder { get; set; }

    [JsonProperty("orderType")]
    public OrderType OrderType { get; set; }

    [JsonProperty("side")]
    public Side Side { get; set; }
}

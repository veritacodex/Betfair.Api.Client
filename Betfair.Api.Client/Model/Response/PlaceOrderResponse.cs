using System.Collections.Generic;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class PlaceOrderResponse
{
    [JsonProperty("marketId")]
    public string MarketId { get; set; }

    [JsonProperty("instructionReports")]
    public List<InstructionReport> InstructionReports { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}
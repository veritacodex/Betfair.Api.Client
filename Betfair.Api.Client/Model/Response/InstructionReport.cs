using System;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class InstructionReport
{
    [JsonProperty("instruction")]
    public Instruction Instruction { get; set; }

    [JsonProperty("betId")]
    public string BetId { get; set; }

    [JsonProperty("placedDate")]
    public DateTimeOffset PlacedDate { get; set; }

    [JsonProperty("averagePriceMatched")]
    public long AveragePriceMatched { get; set; }

    [JsonProperty("sizeMatched")]
    public long SizeMatched { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}
using System;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class StatementItem
{
    [JsonProperty("refId")]
    public string RefId { get; set; }

    [JsonProperty("itemDate")]
    public DateTimeOffset ItemDate { get; set; }

    [JsonProperty("amount")]
    public double Amount { get; set; }

    [JsonProperty("balance")]
    public double Balance { get; set; }

    [JsonProperty("legacyData")]
    public StatementItemLegacyData LegacyData { get; set; }

    [JsonProperty("itemClass")]
    public string ItemClass { get; set; }
}

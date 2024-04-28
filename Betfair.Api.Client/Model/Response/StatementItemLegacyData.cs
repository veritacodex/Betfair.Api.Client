using System;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class StatementItemLegacyData
{
    [JsonProperty("avgPrice")]
    public double AvgPrice { get; set; }

    [JsonProperty("betSize")]
    public long BetSize { get; set; }

    [JsonProperty("betType")]
    public string BetType { get; set; }

    [JsonProperty("betCategoryType")]
    public string BetCategoryType { get; set; }

    [JsonProperty("eventId")]
    public long EventId { get; set; }

    [JsonProperty("eventTypeId")]
    public string EventTypeId { get; set; }

    [JsonProperty("fullMarketName")]
    public string FullMarketName { get; set; }

    [JsonProperty("grossBetAmount")]
    public long GrossBetAmount { get; set; }

    [JsonProperty("marketName")]
    public string MarketName { get; set; }

    [JsonProperty("marketType")]
    public string MarketType { get; set; }

    [JsonProperty("placedDate")]
    public DateTimeOffset PlacedDate { get; set; }

    [JsonProperty("selectionId")]
    public string SelectionId { get; set; }

    [JsonProperty("selectionName")]
    public string SelectionName { get; set; }

    [JsonProperty("startDate")]
    public DateTimeOffset StartDate { get; set; }

    [JsonProperty("transactionType")]
    public string TransactionType { get; set; }

    [JsonProperty("transactionId")]
    public string TransactionId { get; set; }

    [JsonProperty("winLose")]
    public string WinLose { get; set; }

    [JsonProperty("avgPriceRaw")]
    public double AvgPriceRaw { get; set; }
}
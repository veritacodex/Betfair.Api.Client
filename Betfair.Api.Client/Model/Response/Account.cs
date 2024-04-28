using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class Account
{
    [JsonProperty("requestedOn")]
    public string RequestedOn { get; set; }

    [JsonProperty("availableToBetBalance")]
    public long AvailableToBetBalance { get; set; }

    [JsonProperty("exposure")]
    public long Exposure { get; set; }

    [JsonProperty("retainedCommission")]
    public long RetainedCommission { get; set; }

    [JsonProperty("exposureLimit")]
    public long ExposureLimit { get; set; }

    [JsonProperty("discountRate")]
    public long DiscountRate { get; set; }

    [JsonProperty("pointsBalance")]
    public long PointsBalance { get; set; }

    [JsonProperty("wallet")]
    public string Wallet { get; set; }    
}
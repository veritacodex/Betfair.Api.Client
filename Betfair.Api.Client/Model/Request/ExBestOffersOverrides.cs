using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Request;

public class ExBestOffersOverrides
{
    [JsonProperty(PropertyName = "bestPricesDepth")]
    public int BestPricesDepth { get; set; }

    [JsonProperty(PropertyName = "rollupModel")]
    public RollUpModel RollUpModel { get; set; }

    [JsonProperty(PropertyName = "rollupLimit")]
    public int RollUpLimit { get; set; }

    [JsonProperty(PropertyName = "rollupLiabilityThreshold")]
    public double RollUpLiabilityThreshold { get; set; }

    [JsonProperty(PropertyName = "rollupLiabilityFactor")]
    public int RollUpLiabilityFactor { get; set; }
}

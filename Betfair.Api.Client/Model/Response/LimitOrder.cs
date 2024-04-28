using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class LimitOrder
{
    [JsonProperty(PropertyName = "size")]
    public double Size { get; set; }

    [JsonProperty(PropertyName = "price")]
    public double Price { get; set; }

    [JsonProperty(PropertyName = "persistenceType")]
    public string PersistenceType { get; set; }

    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }
}
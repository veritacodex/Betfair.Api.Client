using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class Login
{
    [JsonProperty("updatedOn")]
    public string UpdatedOn { get; set; }

    [JsonProperty("sessionToken")]
    public string SessionToken { get; set; }

    [JsonProperty("loginStatus")]
    public string LoginStatus { get; set; }

    [JsonProperty("apiKey")]
    public string ApiKey { get; set; }
}
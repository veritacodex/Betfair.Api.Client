using Newtonsoft.Json;

namespace Betfair.Api.Client;

public class Auth
{
    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }
}

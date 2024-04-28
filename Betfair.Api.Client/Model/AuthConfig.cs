using Newtonsoft.Json;

namespace Betfair.Api.Client;

public class AuthConfig
{
    [JsonProperty("versionId")]
    public long VersionId { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("applicationKey")]
    public string ApplicationKey { get; set; }

    [JsonProperty("applicationName")]
    public string ApplicationName { get; set; }
}
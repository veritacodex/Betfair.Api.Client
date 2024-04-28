using System.Collections.Generic;
using System.IO;
using Betfair.Api.Client.Model.Response;
using Newtonsoft.Json;

namespace Betfair.Api.Client;

public static class FileHelper
{
    public static Auth GetAuthorization(string certFolder)
    {
        return JsonConvert.DeserializeObject<Auth>(File.ReadAllText(certFolder + FileConstants.AUTH_FILE));
    }
    public static AuthConfig GetAuthorizationConfig(string certFolder)
    {
        var configs = JsonConvert.DeserializeObject<List<AuthConfig>>(File.ReadAllText(certFolder + FileConstants.CONFIG_FILE));
        return configs.Find(x => x.Version == HeaderConstants.APPLICATION_KEY_VERSION);
    }

    public static Login GetLoginResponse(string certFolder)
    {
        return JsonConvert.DeserializeObject<Login>(File.ReadAllText(certFolder + FileConstants.SESSION_TOKEN_FILE));
    }
}

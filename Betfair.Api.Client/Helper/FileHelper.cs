using System.Collections.Generic;
using System.IO;
using System.Linq;
using Betfair.Api.Client.Model.Response;
using Newtonsoft.Json;

namespace Betfair.Api.Client;

public class FileHelper
{
    public static Auth GetAuthorization()
    {
        return JsonConvert.DeserializeObject<Auth>(File.ReadAllText(FileConstants.CERT_FOLDER + FileConstants.AUTH_FILE));
    }
    public static AuthConfig GetAuthorizationConfig()
    {
        var configs = JsonConvert.DeserializeObject<List<AuthConfig>>(File.ReadAllText(FileConstants.CERT_FOLDER + FileConstants.CONFIG_FILE));
        return configs.FirstOrDefault(x => x.Version == HeaderConstants.APPLICATION_KEY_VERSION);
    }

    public static Login GetLoginResponse()
    {
        return JsonConvert.DeserializeObject<Login>(File.ReadAllText(FileConstants.CERT_FOLDER + FileConstants.SESSION_TOKEN_FILE));
    }
}

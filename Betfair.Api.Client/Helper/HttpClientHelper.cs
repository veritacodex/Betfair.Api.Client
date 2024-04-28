using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Betfair.Api.Client;

public class HttpClientHelper(string certFolder)
{
    private readonly string _certFolder = certFolder;

    private HttpClient GetHttpClient(string baseUri)
    {
        var config = FileHelper.GetAuthorizationConfig(_certFolder);
        var loginResponse = FileHelper.GetLoginResponse(_certFolder);
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUri)
        };
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HeaderConstants.ACCEPT_TYPE));
        httpClient.DefaultRequestHeaders.Add(HeaderConstants.HEADER_APPLICATION_KEY, config.ApplicationKey);
        httpClient.DefaultRequestHeaders.Add(HeaderConstants.HEADER_SESSION_TOKEN, loginResponse.SessionToken);
        return httpClient;
    }

    public async Task<string> GetResponse(string apiUrl, string method, Dictionary<string, object> parameters)
    {
        var jsonDictionary = JsonConvert.SerializeObject(parameters);
        var content = new StringContent(jsonDictionary, Encoding.UTF8, HeaderConstants.ACCEPT_TYPE);
        var httpClient = GetHttpClient(apiUrl);
        var response = await httpClient.PostAsync(method, content);
        return await response.Content.ReadAsStringAsync();
    }
}

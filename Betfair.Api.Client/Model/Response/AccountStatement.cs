using System.Collections.Generic;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class AccountStatement
{
    [JsonProperty("accountStatement")]
    public List<StatementItem> StatementItems { get; set; }
}
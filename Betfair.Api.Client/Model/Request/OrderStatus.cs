using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Request;

[JsonConverter(typeof(StringEnumConverter))]
public enum OrderStatus
{
    EXECUTION_COMPLETE,
    EXECUTABLE
}

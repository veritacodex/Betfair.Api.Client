using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Response;

[JsonConverter(typeof(StringEnumConverter))]
public enum Side
{
    BACK, LAY
}

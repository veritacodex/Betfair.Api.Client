using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Request;

[JsonConverter(typeof(StringEnumConverter))]
public enum MarketSort
{
    MINIMUM_TRADED, MAXIMUM_TRADED, MINIMUM_AVAILABLE, MAXIMUM_AVAILABLE, FIRST_TO_START, LAST_TO_START,
}

using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Request;

[JsonConverter(typeof(StringEnumConverter))]
public enum MarketBettingType
{
    ODDS,
    LINE,
    RANGE,
    ASIAN_HANDICAP_DOUBLE_LINE,
    ASIAN_HANDICAP_SINGLE_LINE,
    FIXED_ODDS
}
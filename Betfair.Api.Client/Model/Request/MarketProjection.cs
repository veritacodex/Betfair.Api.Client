using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Request;

[JsonConverter(typeof(StringEnumConverter))]
public enum MarketProjection
{
    COMPETITION, EVENT, EVENT_TYPE, MARKET_DESCRIPTION, RUNNER_DESCRIPTION, RUNNER_METADATA, MARKET_START_TIME
}

using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Response;

[JsonConverter(typeof(StringEnumConverter))]
public enum PersistenceType
{
    LAPSE,              // lapse the order at turn-in-play
    PERSIST,            // put the order into the auction (SP) at turn-in-play
    MARKET_ON_CLOSE,    // put the order into the auction (SP) at turn-in-play
}
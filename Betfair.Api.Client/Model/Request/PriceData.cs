using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Betfair.Api.Client.Model.Request;

[JsonConverter(typeof(StringEnumConverter))]
public enum PriceData
{
    SP_AVAILABLE, SP_TRADED,
    EX_BEST_OFFERS, EX_ALL_OFFERS, EX_TRADED,
}

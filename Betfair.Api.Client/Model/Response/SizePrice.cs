using System.Text;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class SizePrice
{
    [JsonProperty(PropertyName = "price")]
    public double Price { get; set; }

    [JsonProperty(PropertyName = "size")]
    public double Size { get; set; }

    public override string ToString()
    {
        return new StringBuilder().AppendFormat("{0}@{1}", Size, Price)
                    .ToString();
    }
}
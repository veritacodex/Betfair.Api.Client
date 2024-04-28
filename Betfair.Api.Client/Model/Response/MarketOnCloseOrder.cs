﻿using System.Text;
using Newtonsoft.Json;

namespace Betfair.Api.Client.Model.Response;

public class MarketOnCloseOrder
{
    [JsonProperty(PropertyName = "size")]
    public double Size { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
                    .AppendFormat("Size={0}", Size)
                    .ToString();
    }
}

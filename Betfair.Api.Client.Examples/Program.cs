using System.Threading.Tasks;
using Betfair.Api.Client.Model.Request;

namespace Betfair.Api.Client.Examples
{
    static class Program
    {
        static async Task Main()
        {
            var client = new BetfairApiClient("pathToCertFolder");
            var events = await client.GetEvents(EventTypeIds.FootballEventId, 1);
        }
    }
}

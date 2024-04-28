using System;
using System.Threading.Tasks;

namespace Betfair.Api.Client.Examples
{
    class Program
    {
        static async Task Main()
        {
            var client = new BetfairApiClient("pathToCertFolder");
            var account = await client.GetAccount();
            Console.WriteLine("Account:");
            Console.WriteLine($"\tAvailableToBet:{account.AvailableToBetBalance}");
        }
    }
}

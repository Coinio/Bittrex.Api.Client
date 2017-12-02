using System;
using System.Threading.Tasks;
using Bittrex.Api.Client;

class Program
{
    static async Task Main()
    {
        var client = new BittrexClient("key", "secret");

        var result = await client.GetMarkets()
            .ConfigureAwait(false);

        foreach (var market in result.Result)
        {
            await Console.Out.WriteLineAsync(market.MarketName)
                .ConfigureAwait(false);
        }
    }
}

# Bittrex.Api.Client

Nuget:

https://www.nuget.org/packages/Bittrex.Api.Client

This is a simple C# http client wrapper for the Bittrex cryptocurrency trading platform Api. This can be used to query price information, create buy / sell orders, etc.

The docs for the Api can be found here: 

https://www.bittrex.com/Home/Api

DISCLAIMER: This code is provided for learning purposes only and I take no responsibility for any issues. Have fun!

Example Usage:

Create a new instance of the client

```CS

String apiKey = "<api-key-from-bittrex>";
String apiSecret = "<secret-from-bittrex>";
  
BittrexClient client = new BittrexClient("https://bittrex.com/api", apiKey, apiSecret);

```

Get a 24 hour summary of all bittrex markets

```CS

// NOTE:
// All return values are wrapped in an ApiResult<T> as the bittrex Api specfies all results in the format:
// { "success" : "<true/false">, "message" : "<errors>", "result" : "<actual-request-data>" }

ApiResult<MarketSummary[]> summaries = await client.GetMarketSummaries();

```

Create a buy order for some FACTOM! 

```CS

var buyResult = await client.BuyLimit("BTC-FCT", quantity: 100m, rate: 0.00001837m);

if (buyResult.Success)
      Console.WriteLine("To the moon!");

```

# Bittrex.Api.Client

This is a simple C# http client wrapper for the Bittrex cryptocurrency trading platform Api. This can be used to query price information, create buy / sell orders, etc.

The docs for the Api can be found here: 

- https://www.bittrex.com/Home/Api

**DISCLAIMER: This code is provided for learning purposes only and I take no responsibility for any issues. Have fun!**


## Installation via Nuget

The Nuget package is **Bittrex.Api.Client**:

- https://www.nuget.org/packages/Bittrex.Api.Client


## Example Usage

### Create a new instance of the client


#### Using AppSettings

```CS
var appSettings = ConfigurationManager.AppSettings;
var apiKey = appSettings["BittrexClient/ApiKey"];
var apiSecret = appSettings["BittrexClient/ApiSecret"];
  
var client = new BittrexClient(apiKey, apiSecret);
```

#### Using Environment variables

```CS
var envvars = Environment.GetEnvironmentVariables();
var apiKey = (string)envvars["BITTREX_KEY"]
var apiSecret = (string)envvars["BITTREX_SECRET"]
  
var client = new BittrexClient(apiKey, apiSecret);
```


### Get a 24 hour summary of all bittrex markets

```CS
// NOTE:
// All return values are wrapped in an ApiResult<T> as the bittrex Api specfies all results in the format:
// { "success" : "<true/false">, "message" : "<errors>", "result" : "<actual-request-data>" }

ApiResult<MarketSummary[]> summaries = await client.GetMarketSummaries().ConfigureAwait(false);;
```

### Create a buy order for some FACTOM! 

```CS
var buyResult = await client.BuyLimit("BTC-FCT", quantity: 100m, rate: 0.00001837m).ConfigureAwait(false);

if (buyResult.Success)
      await ConsoleOut.WriteLineAsync("To the moon!").ConfigureAwait(false);
```

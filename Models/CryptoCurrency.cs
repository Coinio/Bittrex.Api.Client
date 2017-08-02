using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// The result of the /public/getcurrencies end point
    /// This contains the details of a tradeable currency on the bittrex trading platform
    /// </summary>
    public class CryptoCurrency
    {
        public String Currency { get; set; }
        public String CurrencyLong { get; set; }
        public int MinConfirmation { get; set; }
        public Decimal TxFee { get; set; }
        public bool IsActive { get; set; }
        public String CoinType { get; set; }
        public String BaseAddress { get; set; }
        public String Notice { get; set; }
    }
}

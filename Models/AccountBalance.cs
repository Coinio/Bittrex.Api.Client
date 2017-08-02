using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// Contains the account balance for a particular currency
    /// </summary>
    public class AccountBalance
    {
        public String Currency { get; set; }
        public Decimal Balance { get; set; }
        public Decimal Available { get; set; }
        public Decimal Pending { get; set; }
        public String CryptoAddress { get; set; }
        public bool Requested { get; set; }
        public String Uuid { get; set; }
    }
}

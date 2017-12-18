using System;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// An open order result from the /market/getopenorders end point
    /// </summary>
    public class WithdrawalHistory
    {
        public int Id { get; set; }
        public Decimal Amount { get; set; }
        public String Currency { get; set; }
        public int Confirmations { get; set; }
        public DateTime LastUpdated { get; set; }
        public String TxId { get; set; }
        public String CryptoAddress { get; set; }
    }
}

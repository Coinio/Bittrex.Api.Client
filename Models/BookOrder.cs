using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    public enum BookOrderType
    {
        Buy,
        Sell
    }

    /// <summary>
    /// The result of the /public/getorderbook end point
    /// This contains a single book order for the request
    /// </summary>
    public class BookOrder
    {
        public BookOrderType OrderType { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Rate { get; set; }
    }
}

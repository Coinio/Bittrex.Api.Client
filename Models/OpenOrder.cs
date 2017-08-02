using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    /// <summary>
    /// An open order result from the /market/getopenorders end point
    /// </summary>
    public class OpenOrder
    {
        public Guid? Uuid { get; set; }
        public Guid OrderUuid { get; set; }
        public String Exchange { get; set; }
        public String OrderType { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal QuantityRemaining { get; set; }
        public Decimal Limit { get; set; }
        public Decimal CommissionPaid { get; set; }
        public Decimal Price { get; set; }
        public Decimal? PricePerUnit { get; set; }
        public DateTime Opened { get; set; }
        public DateTime? Closed { get; set; }
        public bool CancelInitiated { get; set; }
        public bool ImmediateOrCancel { get; set; }
        public bool IsConditional { get; set; }
        public String Condition { get; set; }
        public String ConditionTarget { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bittrex.Api.Client.Models
{
    public class HistoricAccountOrder
    {
        public Guid OrderUuid { get; set; }
        public String Exchange { get; set; }
        public DateTime TimeStamp { get; set; }
        public String OrderType { get; set; }
        public Decimal Limit { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal QuantityRemaining { get;set; } 
        public Decimal Commission { get; set; }
        public Decimal Price { get; set; }
        public Decimal PricePerUnit { get; set; }
        public bool IsConditional { get; set; }
        public String Condition { get; set; }
        public String ConditionTarget { get; set; }
        public bool ImmediateOrCancel { get; set; }
    }
}

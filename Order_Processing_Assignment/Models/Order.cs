using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Processing_Assignment.Models
{
    public class Order
    {
        public decimal Amount { get; set; }
        public string CustomerType { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalTotal { get; set; }
    }

}
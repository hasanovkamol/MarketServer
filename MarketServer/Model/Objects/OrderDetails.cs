using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entity
{
   public class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public Product product { get; set; }
        public int productid { get; set; }

        public int Quantity { get; set; }
        public decimal Prices { get; set; }
    }
}

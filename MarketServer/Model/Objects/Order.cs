using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entity
{
  public  class Order
    {
        public int OrderID { get; set; }
        public OrderDetails Orderdetails { get; set; }
        public int Orderdetailsid { get; set; }
        public DateTime SoldTime { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entity
{
   public class Product
    {
        public int ProductID { get; set; }
        public string Productname { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Categories Categories { get; set; }
        public int CategoryId { get; set; }
        public Customer customer { get; set; }
        public int customerid { get; set; }
        public DateTime OutturnTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }

        public List<OrderDetails> order_details { get; set; }
    }
}

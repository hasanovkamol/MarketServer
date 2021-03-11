using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Entity
{
   public class Rebate
    {
        [Key]
        public int RebateID { get; set; }
        public Product product { get; set; }
        public int Productid { get; set; }
        public int Percentage { get; set; }
    }
}

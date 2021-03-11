using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Entity
{
   public class Customer
    {
        public int CustomerID { get; set; }
        [Required (ErrorMessage ="Ism, Familyani kiriting")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Conpanyani nomini kiriting")]
        public string CompaneyName { get; set; }
        [Required(ErrorMessage ="Companyani telifon nomerni kiriting!")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Companyani manzilini kiriting")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Shartnoman nomi kirtilmadi")]
        public string ContractName { get; set; }
        [Required(ErrorMessage ="Shartnomani haqida ma'lumot bering")]
        public string ContractTitle { get; set; }
        
        public List<Product> products { get; set; }

        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

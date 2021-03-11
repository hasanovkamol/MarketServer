using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Shop.Entity
{
   public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Ushbu maydon bo'sh qolish mumkin emas!")]
        public string Categoryname { get; set; }
        [Required(ErrorMessage ="Kiritilgan Category bo'yicha ma'lumot kirting!")]
        public string Descreption { get; set; }

        public List<Product> Products { get; set; }
    }
}

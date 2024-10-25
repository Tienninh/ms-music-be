using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public List<ProductInProductDetail> productInProductDetails { get; set; }


    }
}
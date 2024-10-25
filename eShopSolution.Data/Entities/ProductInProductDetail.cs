using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class ProductInProductDetail 
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int ProductDetailId { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}

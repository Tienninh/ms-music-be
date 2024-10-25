using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image {  get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public List<ProductInProductDetail> productInProductDetails { get; set; }




    }
}

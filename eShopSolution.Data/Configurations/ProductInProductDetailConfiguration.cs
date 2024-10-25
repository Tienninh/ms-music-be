using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configurations
{
    //config bảng có 2 bàng nối với nhau bởi khóa ngoại 
    //trường hơpj nhiều nhiều " many to many " 
    public class ProductInProductDetailConfiguration : IEntityTypeConfiguration<ProductInProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductInProductDetail> builder)
        {

            builder.ToTable("ProductInProductDetail");
            builder.HasKey(t => new { t.ProductId, t.ProductDetailId });
            builder.HasOne(t => t.Product).WithMany(pp => pp.productInProductDetails).HasForeignKey(pp => pp.ProductId);
            builder.HasOne(t => t.ProductDetail).WithMany(pp => pp.productInProductDetails).HasForeignKey(pp => pp.ProductDetailId);

        }
    }
}

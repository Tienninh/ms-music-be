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
    public class ProductDetailConfiguraions : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            /*throw new NotImplementedException();*/
            builder.ToTable("ProductDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            //HasDefaultValue : truyen gia tri mac dinh
            builder.Property(x =>x.Description).HasDefaultValue("No description");
        }
    }
}

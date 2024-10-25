using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configgurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            /* throw new NotImplementedException();*/
            //Cấu hình cho bảng db và các thuộc tính của bảng 
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Location).IsRequired();

        }
    }
}

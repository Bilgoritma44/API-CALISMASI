using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId=1,Name="Oppo A74",Price=5000,Stock=50,CreateDate=DateTime.Now},
                new Product { Id = 2, CategoryId = 2,Name="Lenovo", Price = 3000, Stock = 150, CreateDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 3, Name="Mutfak Robotu", Price = 2000, Stock = 75, CreateDate = DateTime.Now });
        }
    }
}

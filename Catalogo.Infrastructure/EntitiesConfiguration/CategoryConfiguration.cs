using Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infrastructure.EntitiesConfiguration
{
    public class CategoryConfiguration
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImageUrl).HasMaxLength(100).IsRequired();
            builder.HasData(
              new Category(1, "Material Escolar", "material.jpg"),
              new Category(2, "Eletrônicos", "eletronicos.jpg"),
              new Category(3, "Acessórios", "acessorios.jpg")
            );
        }
    }
}

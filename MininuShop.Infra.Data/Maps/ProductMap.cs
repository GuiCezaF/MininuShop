using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MininuShop.Domain.Entities;

namespace MininuShop.Infra.Data;

public class ProductMap : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {
    builder.HasMany(x => x.Purchases)
       .WithOne(p => p.Product)
       .HasForeignKey(x => x.ProductId);
  }
}

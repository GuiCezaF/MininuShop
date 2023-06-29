using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MininuShop.Domain.Entities;

namespace MininuShop.Infra.Data;

public class PurchaseMap : IEntityTypeConfiguration<Purchase>
{
  public void Configure(EntityTypeBuilder<Purchase> builder)
  {
    builder.HasOne(x => x.Person).WithMany(x => x.Purchases);

    builder.HasOne(x => x.Product).WithMany(x => x.Purchases);
  }
}

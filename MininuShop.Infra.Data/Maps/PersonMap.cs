using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MininuShop.Domain.Entities;

namespace MininuShop.Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasMany(c => c.Purchases).WithOne(p => p.Person).HasForeignKey(c => c.PersonId);
        }
    }
}
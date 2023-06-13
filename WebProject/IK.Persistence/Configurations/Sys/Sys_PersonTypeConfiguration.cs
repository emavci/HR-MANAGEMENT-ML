using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IK.Persistence.Configurations.Sys
{
    public class Sys_PersonTypeConfiguration : IEntityTypeConfiguration<Sys_PersonType>
    {
        public void Configure(EntityTypeBuilder<Sys_PersonType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        }
    }
}

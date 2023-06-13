using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IK.Persistence.Configurations.Sys
{
    public class Sys_PersonConfiguration : IEntityTypeConfiguration<Sys_Person>
    {
        public void Configure(EntityTypeBuilder<Sys_Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PersonFingerID).IsRequired(false);
            builder.Property(x => x.SyncID).IsRequired(false);
           
            builder.HasOne(x => x.PersonType)
            .WithMany(x => x.Persons)
            .HasForeignKey(x => x.PersonTypeID);



        }
    }
}

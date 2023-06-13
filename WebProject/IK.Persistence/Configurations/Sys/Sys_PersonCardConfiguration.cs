using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IK.Persistence.Configurations.Sys
{
    public class Sys_PersonCardConfiguration : IEntityTypeConfiguration<Sys_PersonCard>
    {
        public void Configure(EntityTypeBuilder<Sys_PersonCard> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FathersName).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.BirthDate).IsRequired(false);
            builder.Property(x => x.ExitedAt).IsRequired(false);
            builder.Property(x => x.EnteredAt).IsRequired(false);
            builder.Property(x => x.LFile).IsRequired(false);
            builder.Property(x => x.FathersName).IsRequired(false);
            builder.Property(x => x.MothersName).IsRequired(false);
            builder.Property(x => x.Nationality).IsRequired(false);
            builder.Property(x => x.Serial_No).IsRequired(false);
            builder.Property(x => x.ID_No).IsRequired(false);
            builder.Property(x => x.BirthPlace).IsRequired(false);
            builder.Property(x => x.DriverLicense).IsRequired(false);
            builder.Property(x => x.FootNumber).IsRequired(false);
            builder.Property(x => x.Body).IsRequired(false);
            builder.Property(x => x.Weight).IsRequired(false);
            builder.Property(x => x.Height).IsRequired(false);
            builder.Property(x => x.MaritalStatus).IsRequired(false);
            builder.Property(x => x.Gender).IsRequired(false);

            builder.HasOne(x => x.SysCompany)
            .WithMany(x => x.PersonCards)
            .HasForeignKey(x => x.SysCompanyID);

        }
    }
}

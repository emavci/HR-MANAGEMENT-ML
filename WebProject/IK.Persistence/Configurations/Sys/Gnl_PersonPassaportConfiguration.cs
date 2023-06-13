using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Configurations.Sys
{
    public class Gnl_PersonPassaportConfiguration : IEntityTypeConfiguration<Gnl_PersonPassaport>
    {
        public void Configure(EntityTypeBuilder<Gnl_PersonPassaport> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.code).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.type).IsRequired(false).HasMaxLength(50);
        }
    }
}

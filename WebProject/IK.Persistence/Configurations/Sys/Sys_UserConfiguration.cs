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
    public class Sys_UserConfiguration : IEntityTypeConfiguration<Sys_User>
    {
        public void Configure(EntityTypeBuilder<Sys_User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Utype).IsRequired(false);
            builder.Property(x => x.Note).IsRequired(false);
        }
    }
}

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
    public class Gnl_LeaveTypeConfiguration : IEntityTypeConfiguration<Gnl_LeaveType>
    {
        public void Configure(EntityTypeBuilder<Gnl_LeaveType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        }
    }
}

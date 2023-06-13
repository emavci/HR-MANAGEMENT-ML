using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IK.Domain.Concrete.Tahmin;

namespace IK.Persistence.Configurations.Sys
{
    public class Gnl_LeaveConfiguration : IEntityTypeConfiguration<personleaves>
    {
        public void Configure(EntityTypeBuilder<personleaves> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.SysLeaveType)
.WithMany(x => x.PersonLeaves)
.HasForeignKey(x => x.SysLeaveTypeID);

        }
    }
}

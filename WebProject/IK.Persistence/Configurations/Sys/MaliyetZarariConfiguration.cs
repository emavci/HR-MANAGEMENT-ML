using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Tahmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Configurations.Sys
{
    public class MaliyetZarariConfiguration : IEntityTypeConfiguration<maliyetzarari>
    {
        public void Configure(EntityTypeBuilder<maliyetzarari> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}

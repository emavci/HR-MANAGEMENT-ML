using IK.Domain.Concrete.Gnl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Configurations.Sys
{
    public class Gnl_PersonConPositionConfiguration : IEntityTypeConfiguration<Gnl_PersonConPosition>
    {
        public void Configure(EntityTypeBuilder<Gnl_PersonConPosition> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.Person)
            //.WithMany(x => x.PersonConPositions)
            //.HasForeignKey(x => x.PersonId);
        }
    }
}

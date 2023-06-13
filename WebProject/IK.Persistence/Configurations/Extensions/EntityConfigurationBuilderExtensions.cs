using IK.Persistence.Configurations.Sys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Configurations.Extensions
{
    public static class EntityConfigurationBuilderExtensions
    {
        public static void Config(this ModelBuilder modelBuilder){

            modelBuilder.ApplyConfiguration(new Sys_PersonConfiguration());
            modelBuilder.ApplyConfiguration(new Sys_PersonCardConfiguration());
            modelBuilder.ApplyConfiguration(new Gnl_PersonPassaportConfiguration());
            modelBuilder.ApplyConfiguration(new Sys_PersonTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Sys_UserConfiguration());
            modelBuilder.ApplyConfiguration(new Gnl_LeaveConfiguration());
            modelBuilder.ApplyConfiguration(new Gnl_LeaveTypeConfiguration());
        }
    }
}

using IK.Domain.Concrete.Gnl;
using IK.Domain.Concrete.Sys;
using IK.Domain.Concrete.Tahmin;
using IK.Persistence.Configurations.Extensions;
using IK.Persistence.Configurations.Sys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Persistence.Context
{
    public class IKContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public IKContext(DbContextOptions<IKContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityConfigurationBuilderExtensions.Config(modelBuilder);
            modelBuilder.Config();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Sys_Person> Sys_Persons { get; set; }
        public DbSet<Sys_Company> Sys_Companies { get; set; }
        public DbSet<Sys_Position> Sys_Position { get; set; }
        public DbSet<Sys_PersonType> Sys_PersonTypes { get; set; }
        public DbSet<Sys_PersonCard> Sys_PersonCard { get; set; }
        public DbSet<Gnl_PersonConPosition> Gnl_PersonConPositions { get; set; }
        public DbSet<Gnl_PersonPassaport> Gnl_PersonPassaports { get; set; }
        public DbSet<Sys_User> Sys_Users { get; set; }
        public DbSet<personleaves> personleaves { get; set; }
        public DbSet<Gnl_LeaveType> LeaveTypes { get; set; }
        public DbSet<maliyetzarari> maliyetzarari { get; set; }
        public DbSet<totaltahmin> totaltahmin { get; set; }
        public DbSet<zarartahmini> zarartahmini { get; set; }
        public DbSet<Sys_Social> sys_Socials { get; set; }
    }
}

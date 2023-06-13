using IK.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IK.Application.Repositories.Sys;
using IK.Persistence.Repositories.Base.Ef.Sys;
using IK.Application.Repositories.Base;
using IK.Persistence.Repositories.Base.Ef.UnitOfWork;
using IK.Persistence.Repositories.Base.Ef.Repository;
using IK.Domain.Concrete.Sys;
using IK.Application.Repositories.Gnl;
using IK.Domain.Concrete.Gnl;
using IK.Application.Interfaces.Repositories.Gnl;

namespace IK.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<IKContext>(options => options.UseNpgsql("User ID=postgres;Password=1234;Server=localhost;Port=5432;Database=IK;"));

            services.AddScoped<ISys_PersonCardRepository, Sys_PersonCardRepository>();
            services.AddScoped<ISys_PersonRepository, Sys_PersonRepository>();
            services.AddScoped<ISys_PersonTypeRepository, Sys_PersonTypeRepository>();
            services.AddScoped<IGnl_PersonConPositionRepository, Gnl_PersonConPositionRepository>();
            services.AddScoped<IGnl_PersonPassaportRepository, Gnl_PersonPassaportRepository>();
            services.AddScoped<ISys_UserRepository, Sys_UserRepository>();
            services.AddScoped<ISys_PositionRepository, Sys_PositionRepository>();
            services.AddScoped<ISys_CompanyRepository, Sys_CompanyRepository>();
            services.AddScoped<IGnl_LeaveRepository, Gnl_LeaveRepository>();
            services.AddScoped<IGnl_LeaveTypeRepository, Gnl_LeaveTypeRepository>();
            services.AddScoped<ISys_SocialRepository, Sys_SocialRepository>();
            services.AddScoped<ITotalTahminRepository, TotalTahminRepository>();
            services.AddScoped<IZararTahminiRepository, ZararTahminiRepository>();

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));


            services.AddScoped<IUnitOfWork, EfUnitOfWork>();
        }
    }
}

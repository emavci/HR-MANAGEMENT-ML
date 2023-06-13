using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Gnl;
using IK.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonCardService, PersonCardService>();
            services.AddTransient<IPersonConPositionService, PersonConPositionService>();
            services.AddTransient<IPersonPassaportService, PersonPassaportService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICurrentBaseService, CurrentBaseService>();
            services.AddTransient<IPersonTypeService, PersonTypeService>();
            services.AddTransient<ISys_PositionService, Sys_PositionService>();
            services.AddTransient<ISys_CompanyService, Sys_CompanyService>();
            services.AddTransient<IPersonLeaveService, PersonLeaveService>();
            services.AddTransient<IGnlLeaveTypeService, PersonLeaveTypeService>();
            services.AddTransient<ISocialService, SocialService>();
            services.AddTransient<ITotalTahminService, TotalTahminService>();
            services.AddTransient<IZararTahminiService, ZararTahminiService>();  
        }
    }
}

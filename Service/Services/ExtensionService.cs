using Common.Dto;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Service.Interfaces;
using Repository.Repositories;

namespace Service.Services
{
    public static class ExtensionService
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<Iservice<OperatorDto>, OperatorService>();
            services.AddScoped<IsExist<OperatorDto>, OperatorService>();
            //services.AddScoped<IAuthService, AuthService>();
            return services;
        }

    }
}

﻿using Manager;
using Manager.Interface;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Interface;

namespace CollegeManagementSystem.ConfigureServices
{
    public static class DependencyInjection
    {
        public static IServiceCollection DependencyInjectionValidation(this IServiceCollection services)
        {

            //...add services
            services.AddSingleton<IDepartmentManager, DepartmentManager>();
            services.AddSingleton<IDepartmentRepositorie, DepartmentRepositorie>();

            return services;
        }
    }
}

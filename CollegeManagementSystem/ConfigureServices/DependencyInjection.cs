using Services;
using Services.Interface;
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

            //Student
            services.AddSingleton<IStudentServices, StudentServices>();
            services.AddSingleton<IStudentRepositore, StudentRepositore>();

            return services;
        }
    }
}

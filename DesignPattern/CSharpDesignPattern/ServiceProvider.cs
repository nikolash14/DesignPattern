
using CSharpDesignPattern.Behavioral.StrategyWithDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSharpDesignPattern
{
    public class ServiceProvider
    {
        public static IServiceProvider CreateServices()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureService)
                .Build();

            return host.Services;
        }
        private static void ConfigureService(IServiceCollection services)
        {
            services.AddTransient<ISalaryCalculator, JuniorEmployeeSalary>();
            services.AddTransient<ISalaryCalculator, SeniorEmployeeSalary>();
            services.AddTransient<SalaryCalulator>();

        }
    }
}

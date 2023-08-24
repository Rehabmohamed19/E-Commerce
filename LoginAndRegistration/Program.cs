using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Data;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Repository.Interface;
using Repository;
using Service;

namespace LoginAndRegistration
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            var form1 = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<CompanyContext>(options =>
                    {
                        options.UseSqlServer("Data Source=.;Initial Catalog=WorxCompany;Integrated Security=true;TrustServerCertificate=True;");//connection string
                    });
                    services.AddScoped<Form1>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IOrderRepository, OrderRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<AdminService>();
                });
        }
    }
}
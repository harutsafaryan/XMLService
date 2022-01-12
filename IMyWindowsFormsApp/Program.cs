using IMyWindowsApp.Data;
using IMyWindowsApp.Services;
using IMyWindowsFormsApp.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlManager;

namespace IMyWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<_IAppCache, _AppCache>();

            services.AddServices()
                    .AddXmlManager()
                    .AddScoped<MainForm>()
                    .AddScoped<SecondForm>();
        } 
    }
}

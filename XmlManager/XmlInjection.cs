using IMyWindowsApp.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlManager;

namespace XmlManager
{
    public static class XmlInvection
    {
        public static IServiceCollection AddXmlManager(this IServiceCollection services)
        {
            services.AddScoped<IXmlManager<Teacher>, XmlManager<Teacher>>();
            services.AddScoped<IXmlManager<Student>, XmlManager<Student>>();
            return services;
        }
    }
}

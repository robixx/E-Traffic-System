using itcl.etraffic.application.Interface;
using itcl.etraffic.infrastructure.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.infrastructure.ServiceDependancy
{
    public static class ServiceInjection
    {
        public static void InjectService(this IServiceCollection services)
        {
            
            services.AddScoped<IDropDown, DropdownService>();
        }
    }
}

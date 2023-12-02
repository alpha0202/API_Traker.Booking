using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarker.Booking.External
{
    public static class ExternalDependencyInjectionService
    {

        public static IServiceCollection AddExternal(this IServiceCollection services,IConfiguration configuration)
        {
            return services;
        }
    }
}

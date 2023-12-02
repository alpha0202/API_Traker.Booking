using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Persistence.DataBase;
namespace Tarker.Booking.Persistence
{
    public static class PersistencelDependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            // conexion objeto js cadena de string.
            var connectionString = configuration.GetConnectionString("AZSQLConnectionString");


            services.AddDbContext<DBService>(opt => opt.UseSqlServer(connectionString));
            //inyeccion de la interfaz
            services.AddScoped<IDBService, DBService>();



            return services;
        }
    }
}

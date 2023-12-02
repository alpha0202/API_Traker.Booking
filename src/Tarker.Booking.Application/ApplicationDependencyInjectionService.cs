using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Application.Configuration;

namespace Tarker.Booking.Application
{
    public static class ApplicationDependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());

            }
            );

            services.AddSingleton(mapper.CreateMapper());

            return services;
        }

    }
}

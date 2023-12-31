﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegistrationApp.BL.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.IoC
{
    public static class BusinessConfig
    {
        public static IServiceCollection AddBsinesses(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<PersonPersonalityBusiness>();
            services.AddScoped<PersonalityBusiness>();
            services.AddScoped<PersonBusiness>();

            return services;
        }
    }
}
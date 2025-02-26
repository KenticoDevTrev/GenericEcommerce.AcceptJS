﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.AcceptJSPaymentGateway
{
    public static class AcceptJSInitialization
    {
        public static IServiceCollection RegisterAcceptJS(this IServiceCollection services, AcceptJSConfiguration options)
        {
            services.AddSingleton<IAcceptJSOptions>(new AcceptJSOptions(options));
            return services;
        }
    }
}

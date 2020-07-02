﻿using DeltaWare.Dependencies;
using SereneApi.Abstractions;
using SereneApi.Abstractions.Handler;
using System;
using SereneApi.Abstractions.Configuration;
using SereneApi.Abstractions.Handler.Options;

namespace SereneApi.Extensions.DependencyInjection.Types
{
    /// <inheritdoc cref="IApiHandlerOptions{TApiHandler}"/>
    internal class ApiHandlerOptions<TApiDefinition>: ApiHandlerOptions, IApiHandlerOptions<TApiDefinition> where TApiDefinition : class
    {
        public Type HandlerType => typeof(TApiDefinition);

        public ApiHandlerOptions(IDependencyProvider dependencies, IConnectionSettings connection) : base(dependencies,
            connection)
        {
        }
    }
}

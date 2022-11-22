using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using LogManager = Infrastructure.Services.LogManager;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection service)
    {
        service.AddTransient<IRepository , Repository>();
        //service.AddSingleton<ILoggerManager, LogManager>();
    }
}
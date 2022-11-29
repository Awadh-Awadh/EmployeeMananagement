using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using LogManager = Infrastructure.Services.LogManager;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection service)
    {
        service.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        //service.AddSingleton<ILoggerManager, LogManager>();
        service.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
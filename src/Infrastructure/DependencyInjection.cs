using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection service)
    {
        service.AddTransient<IRepository , Repository>();
    }
}
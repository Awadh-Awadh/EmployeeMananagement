using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    // configure automapper, mediar and behaviours

    public static void AddApplication(this IServiceCollection service)
    {
        service.AddMediatR(Assembly.GetExecutingAssembly());
    }
    
}
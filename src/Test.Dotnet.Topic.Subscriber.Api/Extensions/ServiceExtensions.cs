using Test.Dotnet.Topic.Subscriber.Core.Interfaces;
using Test.Dotnet.Topic.Subscriber.Core.Services;

namespace Test.Dotnet.Topic.Subscriber.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}

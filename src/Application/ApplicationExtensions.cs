using DiscordBot.Application.Behaviours;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DiscordBot.Application;

public static class ApplicationExtensions
{
    public static IServiceCollection AddCoreApplication(this IServiceCollection services)
    {
        services.AddMediator((options) =>
            {
                options.ServiceLifetime = ServiceLifetime.Scoped;
                options.Assemblies = [Assembly.GetExecutingAssembly()];
                options.PipelineBehaviors = [typeof(LoggingBehaviour<,>)];
                options.NotificationPublisherType = typeof(Mediator.ForeachAwaitPublisher);
            }
        );
        return services;
    }
}

using System.Reflection;
using DesignPatternsNotes.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternsNotes;

public static class Bootstrapper
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPatternsFromAssemblyOf<TMarker>()
        {
            var assembly = typeof(TMarker).Assembly;
        
            var types = assembly.GetTypes()
                .Where(type => typeof(IPattern).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            foreach (var type in types)
            {
                var instance = (IPattern)Activator.CreateInstance(type)!;
                services.AddKeyedScoped(typeof(IPattern), instance.Key, type);
            }

            return services;
        }

        public Dictionary<string, List<IPattern>> BuildExamplesMap()
        {
            return services
                .Where(sd => sd.IsKeyedService && sd.ServiceType == typeof(IPattern))
                .Select(sd =>
                {
                    var implType = sd.KeyedImplementationType!;
                    var instance = (IPattern)Activator.CreateInstance(implType)!;
                    return instance;
                })
                .GroupBy(pattern => pattern.Category) 
                .ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
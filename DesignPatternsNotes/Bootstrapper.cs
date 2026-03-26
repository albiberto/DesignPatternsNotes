using DesignPatternsNotes.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternsNotes;

public static class Bootstrapper
{
    public static IServiceCollection AddPatternsFromAssemblyOf<TMarker>(this IServiceCollection services)
    {
        var assembly = typeof(TMarker).Assembly;
        
        var types = assembly.GetTypes()
            .Where(type => typeof(IPattern).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

        foreach (var type in types) services.AddTransient(typeof(IPattern), type);

        return services;
    }

    public static Dictionary<string, List<IPattern>> BuildExamplesMap(this IServiceProvider provider)
    {
        return provider.GetServices<IPattern>()
            .GroupBy(pattern => pattern.Category) 
            .ToDictionary(g => g.Key, g => g.ToList());
    }
}
using Showcase.API.Repositories.BaseRepository;

namespace Showcase.API.Extensions
{
	public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            var assembly = typeof(ServiceCollectionExtensions).Assembly;
            
            var repositoryInterfaces = assembly.GetTypes()
                .Where(t => t.IsInterface && t.Name.EndsWith("Repository") && t != typeof(IBaseRepository<>))
                .ToList();
            
            var repositoryImplementations = assembly.GetTypes()
                .Where(t => !t.IsInterface && !t.IsAbstract && t.Name.EndsWith("Repository"))
                .ToList();
            
            foreach (var repositoryInterface in repositoryInterfaces)
            {
                var implementation = repositoryImplementations
                    .FirstOrDefault(impl => repositoryInterface.IsAssignableFrom(impl));
                
                if (implementation != null)
                {
                    services.AddScoped(repositoryInterface, implementation);
                }
            }
            
            return services;
        }
    }
} 
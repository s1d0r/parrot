using Microsoft.Extensions.DependencyInjection;

namespace parrot.Extensions
{
    public static class ParrotServiceExtensions
    {
        public static void AddParrot(this IServiceCollection services)
        {
            services.AddSingleton<ParrotService>();
        }
    }
}
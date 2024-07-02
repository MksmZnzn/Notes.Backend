using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notes.Application.Interfaces;

namespace Notes.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");

            services.AddDbContextFactory<NotesDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<INotesDbContext, NotesDbContext>();
            return services;
        }
    }
}

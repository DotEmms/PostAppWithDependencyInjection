using Microsoft.Extensions.DependencyInjection;
using PostApp.Helpers;
using PostApp.Services;
using System;

namespace PostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            RegisterServices(services);
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            ServiceProvider provider = services.BuildServiceProvider();
            provider.GetService<Main>().Run();
        }

        // todo: inject services here
        public static void RegisterServices(ServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddSingleton<Main>();
        }

    }
}

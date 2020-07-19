using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SistemaDeVisitas.Client.Repositorios;
using Tewr.Blazor.FileReader;
using System.Net.Http;

namespace SistemaDeVisitas.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Podremos realizar las configuraciones del sistema de inyeccion de dependencias
            services.AddOptions(); // sistema de autorización 
            services.AddSingleton<ServicioSingleton>();
            services.AddTransient<ServicioTransient>();
            //Cuando se le pida al servicio de inyeccion de dependencias UNA instancia de la interfaz IRepositorio, se le debe retornar
            //una instancia de la clase Repositorio
            services.AddScoped<IRepositorio,Repositorio>();
            //Configuramos el servicio de Tewr.Blazor.FileReader, para poder utilizarla en nuestra aplicación
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}

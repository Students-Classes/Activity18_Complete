using Activity18.RpgGame.Services.Implementations;
using Activity18.RpgGame.Startup;

// TODO: Implementar Inyección de Dependencias en esta aplicación de consola siguiendo las instrucciones de la siguiente
// guía: https://cord-lip-18a.notion.site/Implementaci-n-de-Inyecci-n-de-Dependencias-en-una-aplicaci-n-de-Consola-en-NET-fa56ff02288841339f8fc959402bcff8?pvs=4

// TODO: El registro de Servicios no se hara aquí, se hará en un método estático de la clase ServiceCollectionExtensions
// que se encuentra en el proyecto Activity18.RpgGame/Startup/ServiceCollectionExtensions.cs

// TODO: Una vez hayas hecho la implementación de la inyección de dependencias, deberás de obtener una instancia de la
// IRpgGame y llamar al método Start() para que la aplicación funcione correctamente. .



using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                services.AddTransient<IGreetingService, GreetingService>();
            })
            .Build();

var service = host.Services.GetRequiredService<IGreetingService>();
service.Run();
//perfecto
await host.RunAsync();
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SistemaDeVisitas.Client.Shared.MainLayout;

namespace SistemaDeVisitas.Client.Pages
{
    public class CounterBase: ComponentBase
    {
        // al colocarle PROTECTED estamos haciendo que la propiedad pueda ser utilizada por su clase que hereda de esta
        [Inject] protected ServicioSingleton Singleton { get; set; }
        [Inject] protected ServicioTransient Transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }
        [CascadingParameter] protected AppState appState { get; set; }

        protected int currentCount = 0;
        //Para poder llamar un metodo statico desde javascript
        static int currentCountStatic = 0;
        protected async Task IncrementarCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");//Estamos invocando un metodo estatico de C# desde javascript
        }

        // con esto ya puedo utilizar la invocacion de este metodo estatico desde javascript
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}

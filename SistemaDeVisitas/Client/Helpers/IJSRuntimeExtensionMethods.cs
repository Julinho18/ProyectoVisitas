using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVisitas.Client.Helpers
{// todo esto por el momento es para que la puedan llamar y se pueda utilizar la funcion del confirmar de javascript
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {   //hemos colocalo la funcion de javascript llamada console.log y luego colocamos los parametros de esta funcion
            await js.InvokeVoidAsync("console.log", "prueba de console log");
            //El siguiente es una funcion de javascript pero QUE RETORNA algo, en cambio el de arrbia que es VOID no retorna NADA
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}

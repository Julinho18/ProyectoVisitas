#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69343f57b2f5c928ee91134c89a873226a156d82"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaDeVisitas.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using SistemaDeVisitas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using SistemaDeVisitas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using SistemaDeVisitas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using SistemaDeVisitas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\_Imports.razor"
using SistemaDeVisitas.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
     if (Listado == null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         if (Cargando == null)
        {
            //esto se ejecutará si no colocamos esta etiqueta en el componente PADRE
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "El contenido es nulo  ...");
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
                                                  
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 14 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
             Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 14 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         
    }
    else if (Listado.Count == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         if (NoHayRegistros == null)
        {
            //esto se ejecutará si no colocamos esta etiqueta en el componente PADRE
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar  ...");
#nullable restore
#line 22 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
                                                           
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 26 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
             NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 26 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
                           
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         
    }
    else
    {
        //Ejecutar el redenfragment y mostrar el tipo que yo quiero mostrar
        // El componente padre es ListadoCargoLaborales
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         foreach(var elemento in Listado)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 35 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
             HayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
                                   //Esto se define dentro del componente padre
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
         
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public List<Titem> Listado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

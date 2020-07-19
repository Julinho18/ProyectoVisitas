#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoTrabajadores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0844e82195bef5590503f7649cc404cd95fa1e5b"
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
    public partial class ListadoTrabajadores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display: flex; flex-wrap: wrap; align-content: center;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.SistemaDeVisitas.Client.Shared.ListadoTrabajadores.TypeInference.CreateListadoGenerico_0(__builder, 3, 4, 
#nullable restore
#line 4 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoTrabajadores.razor"
                              Trabajadores

#line default
#line hidden
#nullable disable
            , 5, (trabajador) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenComponent<SistemaDeVisitas.Client.Shared.TrabajadorIndividual>(7);
                __builder2.AddAttribute(8, "Trabajador", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SistemaDeVisitas.Shared.Entidades.Trabajador>(
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoTrabajadores.razor"
                                              trabajador

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "EliminarTrabajadorHIJO", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SistemaDeVisitas.Shared.Entidades.Trabajador>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SistemaDeVisitas.Shared.Entidades.Trabajador>(this, 
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoTrabajadores.razor"
                                                         EliminarTrabajadorPADRE

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\ListadoTrabajadores.razor"
       
    [Parameter] public List<Trabajador> Trabajadores { get; set; }

    async Task EliminarTrabajadorPADRE(Trabajador trabajador)
    {
        var confirmar = await js.Confirm($"Desea eliminar el trabajador {trabajador.No_Trabajador}?");
        if (confirmar)
        { /*Remove es un metodo */
            Trabajadores.Remove(trabajador);
            Console.WriteLine($"Se ha eliminado el trabajador,  {trabajador.No_Trabajador}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.SistemaDeVisitas.Client.Shared.ListadoTrabajadores
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::SistemaDeVisitas.Client.Shared.ListadoGenerico<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

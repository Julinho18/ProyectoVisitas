#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Oficinas\FiltroOficina.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5cd74e7ecfa631e989ac2e8547a65f299531b6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaDeVisitas.Client.Pages.Oficinas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/oficinas/buscar")]
    public partial class FiltroOficina : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Oficinas\FiltroOficina.razor"
       
    private List<Oficina> Oficinas;
    string nombre = "";
    string oficinaSeleccionado = "0";
    private bool futurasoficinas = false; /*Se crearian más de estas propiedades si colcamos más condiciones*/
    private List<Oficina> oficina = new List<Oficina>();

    protected override void OnInitialized()
    {
        Oficinas = repositorio.ObtenerOficinas();
    }

    //La idea de esto es que cuando el cuando el usuario le de clip al NOMBRE se carge los nuevos cargos laborales
    private void NombreKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")//Si se presiona ENTER ejecutar el metodo
        {
            CargarNuevasOficinas();
        }
    }

    private void CargarNuevasOficinas()
    {
        //Lo de abajo es el que hace el FILTRO
        Oficinas = Oficinas.Where(x => x.No_Oficina.ToLower().Contains(nombre.ToLower())).ToList();
        Console.WriteLine($"Nombre de la oficina: {nombre}");
        Console.WriteLine($"Oficina seleccionado: {oficinaSeleccionado}");
        Console.WriteLine($"Futuras oficinas: {futurasoficinas}");
    }

    private void LimpiarOnClick()
    {
        Oficinas = repositorio.ObtenerOficinas();
        nombre = "";
        oficinaSeleccionado = "0";
        futurasoficinas = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591

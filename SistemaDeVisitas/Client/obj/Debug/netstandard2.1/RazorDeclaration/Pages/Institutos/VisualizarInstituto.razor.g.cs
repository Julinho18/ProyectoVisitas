#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Institutos\VisualizarInstituto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdf917b3e77b544bd9b0d4e5d2ab2eac66cba72"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaDeVisitas.Client.Pages.Institutos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/instituto/{InstitutoId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/instituto/{InstitutoId:int}/{NombreInstituto}")]
    public partial class VisualizarInstituto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Institutos\VisualizarInstituto.razor"
       
    [Parameter] public int InstitutoId { get; set; }
    [Parameter] public string NombreInstituto { get; set; }
    protected override void OnInitialized()
    {
        Console.WriteLine($"el id del instituto es: {InstitutoId} y su nombre es : {NombreInstituto}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

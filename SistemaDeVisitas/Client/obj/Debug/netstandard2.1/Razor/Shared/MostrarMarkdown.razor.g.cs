#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aa811d50c33fda665319a319eb3c133228b1552"
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
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class MostrarMarkdown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
 if (string.IsNullOrEmpty(ContenidoHTML))
{
    if (PlantillaCarga != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
         PlantillaCarga

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
                       
    }
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
      (MarkupString)ContenidoHTML

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
                                  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Shared\MostrarMarkdown.razor"
       
    [Parameter] public string ContenidoMarkdown { get; set; } /*Representa el contenido de Markdown*/
    [Parameter] public RenderFragment PlantillaCarga { get; set; }
    private string ContenidoHTML;

    protected override void OnParametersSet()
    {
        if (ContenidoMarkdown != null)
        {
            ContenidoHTML = Markdown.ToHtml(ContenidoMarkdown);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

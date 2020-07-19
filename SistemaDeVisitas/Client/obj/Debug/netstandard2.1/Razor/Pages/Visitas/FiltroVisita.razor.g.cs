#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf8105740be7a4c343c7d965a3ea06a41402b50c"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaDeVisitas.Client.Pages.Visitas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/visitas/buscar")]
    public partial class FiltroVisita : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Filtro Visita</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-inline");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"nombre\" class=\"sr-only\">Id de la Visita</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                              (KeyboardEventArgs e)=> NombreKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "id");
            __builder.AddAttribute(13, "placeholder", "Id de la visita");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                            id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => id = __value, id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                            visitaSeleccionado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => visitaSeleccionado = __value, visitaSeleccionado));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "0");
            __builder.AddContent(28, "--Seleccionar visita--");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 19 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
             foreach (var item in visita)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 21 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, 
#nullable restore
#line 21 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                          item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 22 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "class", "form-check-input");
            __builder.AddAttribute(44, "id", "visita");
            __builder.AddAttribute(45, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                                                           futurasvisitas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurasvisitas = __value, futurasvisitas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<label class=\"form-check-label\" for=\"visitas\">\r\n            Futuros Visitas\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                                                         CargarNuevasVisitas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                                                                LimpiarOnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Limpiar");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.OpenComponent<SistemaDeVisitas.Client.Shared.ListadoVisitas>(63);
            __builder.AddAttribute(64, "Visitas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SistemaDeVisitas.Shared.Entidades.Visita>>(
#nullable restore
#line 37 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
                         Visitas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FiltroVisita.razor"
       
    private List<Visita> Visitas;
    string id = "";
    string visitaSeleccionado = "0";
    private bool futurasvisitas = false; /*Se crearian más de estas propiedades si colcamos más condiciones*/
    private List<Visita> visita = new List<Visita>();

    protected override void OnInitialized()
    {
        Visitas = repositorio.ObtenerVisitas();
    }

    //La idea de esto es que cuando el cuando el usuario le de clip al NOMBRE se carge los nuevos cargos laborales
    private void NombreKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")//Si se presiona ENTER ejecutar el metodo
        {
            CargarNuevasVisitas();
        }
    }

    private void CargarNuevasVisitas()
    {
        //Lo de abajo es el que hace el FILTRO
        Visitas = Visitas.Where(x => x.Motivo.ToLower().Contains(id)).ToList();
        Console.WriteLine($"Id de la Visita: {id}");
        Console.WriteLine($"Id seleccionado: {visitaSeleccionado}");
        Console.WriteLine($"Futuros visitas: {futurasvisitas}");
    }

    private void LimpiarOnClick()
    {
        Visitas = repositorio.ObtenerVisitas();
        id = "";
        visitaSeleccionado = "0";
        futurasvisitas = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591

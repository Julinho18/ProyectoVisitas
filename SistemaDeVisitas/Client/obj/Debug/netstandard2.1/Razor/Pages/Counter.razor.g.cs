#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e06444c6c585c9112850e4fe30fa34b0f14e69"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaDeVisitas.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : CounterBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + " " + (
#nullable restore
#line 5 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                   appState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display:flex;");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "width:150px");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "style", "margin-top:15px");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                        appState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appState.Color = __value, appState.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "green");
            __builder.AddContent(18, "Verde");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "red");
            __builder.AddContent(22, "Rojo");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "blue");
            __builder.AddContent(26, "Azul");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "#F085FB");
            __builder.AddContent(30, "Palo Rosa");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "style", "width:150px");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "select");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "style", "margin-top:15px");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                        appState.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appState.Size = __value, appState.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "12px");
            __builder.AddContent(45, "12px");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "20px");
            __builder.AddContent(49, "20px");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "30px");
            __builder.AddContent(53, "30px");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenElement(58, "p");
            __builder.AddAttribute(59, "style", "color:" + " " + (
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                  appState.Color

#line default
#line hidden
#nullable disable
            ) + ";font-size:" + (
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                                            appState.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Current count: ");
            __builder.AddContent(61, 
#nullable restore
#line 27 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                                                                           currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, "Singleton count: ");
            __builder.AddContent(65, 
#nullable restore
#line 28 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                     Singleton.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenElement(67, "p");
            __builder.AddContent(68, "Transient count: ");
            __builder.AddContent(69, 
#nullable restore
#line 29 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                     Transient.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-primary");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Counter.razor"
                                          IncrementarCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f996c47f5a2fbbb0427554e2fbe0896c63f0cc4f"
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
    public partial class FormularioVisita : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                 Visita

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                   OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Nombre del lugar de la reunion de la visita:</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                                         Visita.No_Lugar_Reunion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Visita.No_Lugar_Reunion = __value, Visita.No_Lugar_Reunion))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Visita.No_Lugar_Reunion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.SistemaDeVisitas.Client.Pages.Visitas.FormularioVisita.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 7 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                      ()=>Visita.No_Lugar_Reunion

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddMarkupContent(27, "<label>Motivo de la visita:</label>\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                                         Visita.Motivo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Visita.Motivo = __value, Visita.Motivo))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Visita.Motivo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.SistemaDeVisitas.Client.Pages.Visitas.FormularioVisita.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 15 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                      ()=>Visita.Motivo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<label>Trabajador visitado:</label>\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddContent(46, "            ");
                __Blazor.SistemaDeVisitas.Client.Pages.Visitas.FormularioVisita.TypeInference.CreateSelectorMultipleTypeahead_2(__builder2, 47, 48, 
#nullable restore
#line 23 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                                     BuscarTrabajadores

#line default
#line hidden
#nullable disable
                , 49, 
#nullable restore
#line 24 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                                               TrabajadoresSeleccionados

#line default
#line hidden
#nullable disable
                , 50, (trabajador) => (__builder3) => {
                    __builder3.AddContent(51, "                    ");
                    __builder3.AddContent(52, 
#nullable restore
#line 26 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                     trabajador.No_Trabajador

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(53, "\r\n                ");
                }
                , 54, (trabajador) => (__builder3) => {
                    __builder3.AddContent(55, "                    ");
                    __builder3.OpenElement(56, "img");
                    __builder3.AddAttribute(57, "style", "width: 50px");
                    __builder3.AddAttribute(58, "src", 
#nullable restore
#line 29 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                                                   trabajador.Imagen

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n                    ");
                    __builder3.AddContent(60, 
#nullable restore
#line 30 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
                     trabajador.No_Trabajador

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(61, "\r\n                ");
                }
                );
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n    ");
                __builder2.AddMarkupContent(65, "<button class=\"btn btn-success\" type=\"submit\">Guardar Cambios</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Julinho\source\repos\SistemaDeVisitas\SistemaDeVisitas\Client\Pages\Visitas\FormularioVisita.razor"
       
    [Parameter] public Visita Visita { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Trabajador> TrabajadoresSeleccionados { get; set; } = new List<Trabajador>();

    private async Task<IEnumerable<Trabajador>> BuscarTrabajadores(string searchText)
    {
        return new List<Trabajador>()
        {
            new Trabajador(){Id=1, No_Trabajador="Tom Holland", Imagen = "https://m.media-amazon.com/images/M/MV5BNTAzMzA3NjQwOF5BMl5BanBnXkFtZTgwMDUzODQ5MTI@._V1_UY317_CR23,0,214,317_AL_.jpg"},
            new Trabajador(){Id=2, No_Trabajador="Tom Hanks", Imagen = "https://m.media-amazon.com/images/M/MV5BMTQ2MjMwNDA3Nl5BMl5BanBnXkFtZTcwMTA2NDY3NQ@@._V1_UY317_CR2,0,214,317_AL_.jpg"}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SistemaDeVisitas.Client.Pages.Visitas.FormularioVisita
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSelectorMultipleTypeahead_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<T>>> __arg0, int __seq1, global::System.Collections.Generic.List<T> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg3)
        {
        __builder.OpenComponent<global::SistemaDeVisitas.Client.Shared.SelectorMultipleTypeahead<T>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ElementosSeleccionados", __arg1);
        __builder.AddAttribute(__seq2, "MyListTemplate", __arg2);
        __builder.AddAttribute(__seq3, "MyResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
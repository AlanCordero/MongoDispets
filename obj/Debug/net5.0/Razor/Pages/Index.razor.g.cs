#pragma checksum "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7b5ac9a5392e804997146e75c47d51577dff2d3d602f3c261272fd060496afbe"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMongoDB.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using BlazorMongoDB

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\_Imports.razor"
using BlazorMongoDB.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
      "/hola-mundo"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>¡Hola Mundo!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Esta es mi primera página en Blazor.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
                  MostrarMensaje

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Haz clic aquí");
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
 if (!string.IsNullOrEmpty(mensaje))
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
        mensaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Index.razor"
       
    private string mensaje;

    private void MostrarMensaje()
    {
        mensaje = "¡Hola, este mensaje es dinámico!";
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
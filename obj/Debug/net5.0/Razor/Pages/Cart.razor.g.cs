#pragma checksum "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a69346ab866d699ffaf9d56b86a95abdb5d835ca1cd122c5355a804047452095"
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

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
 using BlazorMongoDB.Data

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
 using BlazorMongoDB.Service

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
      "/cart"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Cart : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container my-4");
            __builder.AddMarkupContent(2, "<header class=\"text-center mb-4\"><h1 class=\"text-primary\">Carrito de Compras</h1>\r\n        <p class=\"text-muted\">Revisa los productos antes de proceder al pago.</p></header>");
#nullable restore
#line 13 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
     if (CartService.CartProducts.Any())
    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "table-responsive");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(7, "<thead class=\"table-dark\"><tr><th>Producto</th>\r\n                        <th>Precio</th>\r\n                        <th>Acciones</th></tr></thead>\r\n                ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 25 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                     foreach (var product in CartService.CartProducts)
                    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-flex align-items-center");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 30 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                               product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 30 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                                                       product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "img-thumbnail me-2");
            __builder.AddAttribute(17, "style", "width: 50px; height: 50px; object-fit: cover;");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                    ");
            __builder.OpenElement(19, "span");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                           product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, "$");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                  product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                                                                () => RemoveFromCart(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<i class=\"fas fa-trash-alt\"></i> Eliminar\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "d-flex justify-content-between align-items-center mt-4");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "h5");
            __builder.AddMarkupContent(35, "<strong>Total:</strong> $");
            __builder.AddContent(36, 
#nullable restore
#line 47 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                                    CartService.GetTotalPrice()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-success btn-lg");
            __builder.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                                                             ProceedToCheckout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<i class=\"fas fa-shopping-cart\"></i> Proceder al Pago\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(42, "<div class=\"alert alert-warning text-center\" role=\"alert\"><strong>Tu carrito está vacío.</strong>\r\n            <p>Agrega productos para comenzar.</p></div>");
#nullable restore
#line 59 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
       
    private void RemoveFromCart(Product product)
    {
        CartService.RemoveProduct(product);
    }

    private void ProceedToCheckout()
    {
        NavigationManager.NavigateTo("/checkout");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
        CartService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                    CartService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Cart.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

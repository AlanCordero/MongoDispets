#pragma checksum "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "51d581783571367e5e74d847a4288993842ac5f3b38e754d61a13a4ed206723a"
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
#line 2 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
 using BlazorMongoDB.Data

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
 using BlazorMongoDB.IService

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
 using BlazorMongoDB.Service

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
      "/Inicio"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Indexx : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Bienvenido a Dispet</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Productos Destacados</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 13 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
     if (featuredProducts != null)
    {
        foreach (var product in featuredProducts)
        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4 mb-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 19 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                               product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "card-img-top");
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 19 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                                            product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "style", "max-height: 200px; object-fit: cover;");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, 
#nullable restore
#line 21 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "card-text");
            __builder.AddContent(22, 
#nullable restore
#line 22 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                              product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "<strong>Precio:</strong> $");
            __builder.AddContent(26, 
#nullable restore
#line 23 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                      product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                                  () => AddToCart(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Agregar al Carrito");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(32, "<p>Cargando productos destacados...</p>");
#nullable restore
#line 33 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n<hr>\r\n");
            __builder.AddMarkupContent(34, "<h3>Comentarios</h3>\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "comments");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "existing-comments");
#nullable restore
#line 40 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
         if (comments.Any())
        {
            foreach (var comment in comments)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "comment mb-3 p-3 border rounded shadow-sm");
            __builder.OpenElement(41, "p");
            __builder.OpenElement(42, "strong");
            __builder.AddContent(43, 
#nullable restore
#line 45 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                comment.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, ":");
            __builder.CloseElement();
            __builder.AddContent(45, " ");
            __builder.AddContent(46, 
#nullable restore
#line 45 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                            comment.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "p");
            __builder.OpenElement(49, "small");
            __builder.AddContent(50, 
#nullable restore
#line 46 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                               comment.Date.ToString("g")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(51, "<p>No hay comentarios todavía.</p>");
#nullable restore
#line 53 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
        }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.AddMarkupContent(53, "<h4>Agregar un Comentario</h4>\r\n    ");
            __builder.OpenElement(54, "form");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group mb-3");
            __builder.AddMarkupContent(57, "<label>Nombre:</label>\r\n            ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.AddAttribute(60, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                          newComment.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newComment.UserName = __value, newComment.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group mb-3");
            __builder.AddMarkupContent(65, "<label>Comentario:</label>\r\n            ");
            __builder.OpenElement(66, "textarea");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                             newComment.Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newComment.Text = __value, newComment.Text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-primary");
            __builder.AddAttribute(73, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                                                  SubmitComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Enviar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
       
    private List<Comment> comments = new List<Comment>();
    private Comment newComment = new Comment();
    private List<Product> featuredProducts;

    protected override async Task OnInitializedAsync()
    {
        featuredProducts = await ProductService.GetFeaturedProducts();
        comments = await CommentService.GetComments(); // Cargar los comentarios desde la base de datos
    }

    private void AddToCart(Product product)
    {
        CartService.AddProduct(product);
    }

    private async Task SubmitComment()
    {
        if (!string.IsNullOrWhiteSpace(newComment.UserName) && !string.IsNullOrWhiteSpace(newComment.Text))
        {
            newComment.Date = DateTime.UtcNow;

            // Guardar el comentario en la base de datos
            await CommentService.AddComment(newComment);

            // Recargar los comentarios
            comments = await CommentService.GetComments();

            newComment = new Comment(); // Limpiar el formulario
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
        ICommentService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                        CommentService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
        CartService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                    CartService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
        IProductService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Indexx.razor"
                        ProductService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

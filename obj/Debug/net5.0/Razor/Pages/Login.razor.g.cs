#pragma checksum "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bdcfd9febf481b198853bfe80cc24b10b77611a8ad00fed6eaa8a397b5281893"
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
#line 2 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
 using BlazorMongoDB.Data

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
 using BlazorMongoDB.IService

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
      "/"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container my-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card shadow");
            __builder.AddMarkupContent(8, "<div class=\"card-header text-center bg-primary text-white\"><h3>Iniciar Sesión</h3></div>\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
#nullable restore
#line 15 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                     if (!string.IsNullOrEmpty(ErrorMessage))
                    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "alert alert-danger");
            __builder.AddAttribute(13, "role", "alert");
            __builder.AddContent(14, 
#nullable restore
#line 18 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                             ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                    }

#line default
#line hidden
#nullable disable

            __builder.OpenElement(15, "form");
            __builder.AddAttribute(16, "onsubmit", "return false;");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group mb-3");
            __builder.AddMarkupContent(19, "<label for=\"username\" class=\"form-label\">Nombre de Usuario:</label>\r\n                            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "id", "username");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Ingresa tu nombre de usuario");
            __builder.AddAttribute(24, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                                                        loginUser.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginUser.Username = __value, loginUser.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group mb-3");
            __builder.AddMarkupContent(29, "<label for=\"password\" class=\"form-label\">Contraseña:</label>\r\n                            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "id", "password");
            __builder.AddAttribute(32, "type", "password");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "placeholder", "Ingresa tu contraseña");
            __builder.AddAttribute(35, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                                                                        loginUser.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginUser.Password = __value, loginUser.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-primary w-100");
            __builder.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                                                                                      LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Ingresar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-footer text-center");
            __builder.OpenElement(46, "p");
            __builder.AddMarkupContent(47, "¿No tienes cuenta? ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-link");
            __builder.AddAttribute(50, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                                                                                 NavigateToRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "Regístrate aquí");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
       
    private User loginUser = new User();
    private string ErrorMessage;

    private async Task LoginUser()
    {
        if (string.IsNullOrEmpty(loginUser.Username) || string.IsNullOrEmpty(loginUser.Password))
        {
            ErrorMessage = "Todos los campos son obligatorios.";
            return;
        }

        var user = await UserService.GetUserByUsername(loginUser.Username);
        if (user == null || user.Password != loginUser.Password)
        {
            ErrorMessage = "Usuario o contraseña incorrectos.";
            return;
        }

        // Redirigir a la página principal de Dispet
        NavigationManager.NavigateTo("/Inicio");
    }

    private void NavigateToRegister()
    {
        NavigationManager.NavigateTo("/register");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
        IUserService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\e-aycordero\source\repos\BlazorMongoDB\BlazorMongoDB\Pages\Login.razor"
                     UserService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

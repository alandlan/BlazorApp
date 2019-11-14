#pragma checksum "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7fc2e963f738b643d37a31f6f5a1a7ea9e529a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Login.razor"
                          _login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _login = __value, _login));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Login.razor"
                  LoginAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Login.razor"
       _status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Login.razor"
       
    private string _login;
    private string _status;

    private async Task LoginAsync()
    {
        _status = "Fazendo Login";

        string token = await devApi.LoginAsync(_login);
        await ProtectedSessionStorage.SetAsync("token", token);

        if(token != null)
            _status = "Ok";
        else
            _status = "NOk";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TindevApp.Blazor.Data.DevelopersApi devApi { get; set; }
    }
}
#pragma warning restore 1591

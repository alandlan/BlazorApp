#pragma checksum "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e65b0a509f4db69521d432fc454b6668030600ea"
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
#nullable restore
#line 11 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\_Imports.razor"
using TindevApp.Blazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/developers")]
    public class Developers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Developers</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
                  Refresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Refresh");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
     foreach (var item in _developers)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card mb-4 shadow-sm");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 15 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
                           item.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt", 
#nullable restore
#line 15 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
                                              item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "card-text");
            __builder.AddContent(24, 
#nullable restore
#line 17 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, @"<div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Like</button>
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Dislike</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                    </div>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 28 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Alan\Desktop\dotnetWeb\BlazorApp\Pages\Developers.razor"
       
    private List<Developer> _developers = new List<Developer>();

    private async Task Refresh()
    {
        var token = await ProtectedSessionStorage
                    .GetAsync<string>("token");

        var devCollApi = await devApi.GetDevelopersAsync(token);

        _developers.Clear();
        _developers.AddRange(devCollApi);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TindevApp.Blazor.Data.DevelopersApi devApi { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e058cbeda6af212d599a54484e36be6ecc05d3df"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotaru.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Hotaru;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using Hotaru.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Desktop\project\Hotaru\Hotaru\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStrap.BSJumbotron>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n    ");
                __builder2.AddMarkupContent(3, "<h1 class=\"display-4\">Hello, welcome to Hotaru!</h1>\r\n\r\n    ");
                __builder2.AddMarkupContent(4, "<p class=\"lead\">To use Hotaru please Login or Register</p>\r\n\r\n    <hr class=\"my-4\">\r\n\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSButton>(5);
                __builder2.AddAttribute(6, "IsOutline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                     Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                                         Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                                                              nvgToLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(11, "Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSButton>(13);
                __builder2.AddAttribute(14, "IsOutline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                     Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                                          Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
                                                                               nvgToRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "Register");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "G:\Desktop\project\Hotaru\Hotaru\Pages\Index.razor"
      

    public void nvgToLogin()
    {

        nvg.NavigateTo("/login");

    }

    public void nvgToRegister()
    {

        nvg.NavigateTo("/register");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvg { get; set; }
    }
}
#pragma warning restore 1591

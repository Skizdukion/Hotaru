#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Shared\UserNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b3a3b43410c71b55321b4a9d4fa43d558a20f1"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotaru.Shared
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
    public partial class UserNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"/user\">Hotaru</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "G:\Desktop\project\Hotaru\Hotaru\Shared\UserNavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "G:\Desktop\project\Hotaru\Hotaru\Shared\UserNavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "G:\Desktop\project\Hotaru\Hotaru\Shared\UserNavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "/user/information");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                <span class=\"oi oi-info\" aria-hidden=\"true\"></span> User Info\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "/user/hotelbooking");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Hotel Booking\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "nav-item px-3");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "/user/transactionhistory");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                <span class=\"oi oi-laptop\" aria-hidden=\"true\"></span> Transaction History\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "nav-item px-3");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "/user/bookingstatus");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\r\n                <span class=\"oi oi-laptop\" aria-hidden=\"true\"></span> Booking Request\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "G:\Desktop\project\Hotaru\Hotaru\Shared\UserNavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

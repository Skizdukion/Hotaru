#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Staff\CustomerAccounting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b989a4fccf85f4c090ee4190744e1ffea1e8c1c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Hotaru.Pages.Staff
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
#nullable restore
#line 3 "G:\Desktop\project\Hotaru\Hotaru\Pages\Staff\CustomerAccounting.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.StaffLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff/customeraccounting")]
    public partial class CustomerAccounting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "G:\Desktop\project\Hotaru\Hotaru\Pages\Staff\CustomerAccounting.razor"
       
    int Room_temp_locate = new int();
    string Room_temp_name = string.Empty;
    string Price = string.Empty;
    Hotel ht = new Hotel("Valley hotel", "", "", "");
    CustomerTransaction CT = new CustomerTransaction();
    CustomerData model = new CustomerData("Cella Marcelo", "mrcl@gmail.com", "1", "0982481842", "1st Washington", 32, "In Valley Hotel");
    protected override void OnInitialized()
    {
        CT.DatePickInAdvance = DateTime.Now;
        CT.DateReturn = DateTime.Now;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

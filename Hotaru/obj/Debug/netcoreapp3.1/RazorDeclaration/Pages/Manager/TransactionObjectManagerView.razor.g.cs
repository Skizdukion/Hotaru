#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa348663f965fa7eb53ff00fcf594f363c69554"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Hotaru.Pages.Manager
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
#line 3 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.ManagerLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/transactionobjectview")]
    public partial class TransactionObjectManagerView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
      
    CustomerData model = new CustomerData("Cella Marcelo", "mrcl@gmail.com", "1234", "0982481842", "1st Washington", 32, "Transaction Confirm");
    Hotel ht = new Hotel("Valley", "129/2A Broadla Coaster Washington DC", "https://r-cf.bstatic.com/images/hotel/max1024x768/231/231141387.jpg", "Our hotel is 5 star rated on Roasted-Tomato, with about more than 1000m2 in space and 60 room of all kind");
    CustomerTransaction CT;
    protected override void OnInitialized()
    {
        DateTime nowz = DateTime.Now;
        DateTime nowzt = nowz.AddDays(13);
        CT = new CustomerTransaction("Cella Marcelo", "Valley hotel", "Michael", nowz, nowzt, nowzt, "Room for 1 people", 100000, "No adding fee", 0);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

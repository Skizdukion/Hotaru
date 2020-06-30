#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Customer\TransactionHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be31e2f56541d5705dd8028233c4014fe12f8944"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Hotaru.Pages.Customer
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
#line 5 "G:\Desktop\project\Hotaru\Hotaru\Pages\Customer\TransactionHistory.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.UserLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/transactionhistory")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/transactionhistory/{pageId:int}")]
    public partial class TransactionHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 231 "G:\Desktop\project\Hotaru\Hotaru\Pages\Customer\TransactionHistory.razor"
       

    [Parameter]
    public int PageId { get; set; }

    string URLPage(int numPage)
    {
        string temp = "/user/transactionhistory/" + numPage.ToString();
        return temp;
    }

    bool IsFirstPage()
    {
        if (PageId == 0) return true;
        else return false;
    }

    bool IsFinalPage()
    {
        if (PageId == model.MaxPages - 1) return true;
        else return false;
    }

    Pagination model = new Pagination(45, 8);

    TransactionList tl;

    TransactionList Org = new TransactionList(45);

    protected override void OnInitialized()
    {
        tl = Org;
    }

    void navigate()
    {
        nvg.NavigateTo("/user/transactionobjectview");
    }

    void search()
    {
        tl = new TransactionList();
        CustomerTransaction emptytl = new CustomerTransaction();
        tl.transactionList.Add(emptytl);
        for (int i = 1; i < Org.transactionList.Count; i++)
        {
            if (Org.transactionList[i].HotelName.Contains(srchStr, StringComparison.OrdinalIgnoreCase))
                tl.transactionList.Add(Org.transactionList[i]);
            model.MaxObject = tl.transactionList.Count;
        }
    }

    string srchStr = string.Empty;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvg { get; set; }
    }
}
#pragma warning restore 1591
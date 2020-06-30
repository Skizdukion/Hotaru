#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\HotelBookingStatus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71472845d1964f3620aa350a27f2c0914e8881b2"
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
#line 5 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\HotelBookingStatus.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.ManagerLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/bookingstatus")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/bookingstatus/{pageId:int}")]
    public partial class HotelBookingStatus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 234 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\HotelBookingStatus.razor"
       

    [Parameter]
    public int PageId { get; set; }


    string URLPage(int numPage)
    {
        string temp = "/manager/bookingstatus/" + numPage.ToString();
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

    Pagination model = new Pagination(32, 8);

    BookingList Org = new BookingList(32);

    BookingList bkl;

    protected override void OnInitialized()
    {
        bkl = new BookingList();
        BookingData emptyBooking = new BookingData();
        bkl.bookingList.Add(emptyBooking);
        for (int i = 1; i < Org.bookingList.Count; i++)
        {
            //if (Org.bookingList[i].HotelName == HotelName)
            bkl.bookingList.Add(Org.bookingList[i]);
        }
        model = new Pagination(bkl.bookingList.Count, 8);

    }

    string srchStr = string.Empty;

    void search()
    {
        nvg.NavigateTo("/manager/bookingstatus");
        bkl = new BookingList();
        BookingData emptyBooking = new BookingData();
        bkl.bookingList.Add(emptyBooking);
        for (int i = 1; i < Org.bookingList.Count; i++)
        {
            if (Org.bookingList[i].UserName.Contains(srchStr, StringComparison.OrdinalIgnoreCase))
                bkl.bookingList.Add(Org.bookingList[i]);
        }
        model = new Pagination(bkl.bookingList.Count,8);
    }

    void acceptCustomer(int num)
    {
        //add customer to customer management
        BookingData temp = bkl.bookingList[num];
        Org.bookingList.Remove(temp);
        bkl.bookingList.Remove(temp);
        model = new Pagination(bkl.bookingList.Count, 8);
        nvg.NavigateTo("/manager/bookingstatus");
    }

    void declineCustomer(int num)
    {
        BookingData temp = bkl.bookingList[num];
        Org.bookingList.Remove(temp);
        bkl.bookingList.Remove(temp);
        model = new Pagination(bkl.bookingList.Count, 8);
        nvg.NavigateTo("/manager/bookingstatus");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nvg { get; set; }
    }
}
#pragma warning restore 1591

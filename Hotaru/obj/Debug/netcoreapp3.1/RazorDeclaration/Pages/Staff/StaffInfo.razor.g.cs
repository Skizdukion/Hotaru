#pragma checksum "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\Staff\StaffInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ea957f68f29b77c798bd01646dcec72a137d0c"
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
#line 1 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Hotaru;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using Hotaru.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\Staff\StaffInfo.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.StaffLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff/informaion")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/staff")]
    public partial class StaffInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\Staff\StaffInfo.razor"
       

    bool IsEdit = false;

    bool IsChangingPassword = false;

    bool WrongPass = false;

    bool Mismatch = false;

    bool Isempty = false;

    UserData model = new UserData("Cella Marcelo", "mrcl@gmail.com", "1234", "0982481842", "1st Washington", 32);

    string TName = string.Empty;

    string TPhone = string.Empty;

    string TPassword = string.Empty;

    string TAddress = string.Empty;

    string TNPassword = string.Empty;//new password

    string TCPassword = string.Empty;//confrim password

    int TAges;

    private void Editing()
    {
        IsEdit = true;
        TName = model.Name;
        TPhone = model.PhoneNumber;
        TAddress = model.Address;
        TAges = model.Ages;
    }

    private void CancelEdit()
    {
        IsEdit = false;
        TName = string.Empty;
        TPhone = string.Empty;
        TAddress = string.Empty;
        TAges = 0;
    }

    private void SaveEdit()
    {
        if ((string.IsNullOrWhiteSpace(TName)) || (string.IsNullOrWhiteSpace(TPhone)) || (string.IsNullOrWhiteSpace(TAddress)) || (TAges < 0)) Isempty = true;
        if (Isempty == false)
        {
            IsEdit = false;
            model.Name = TName;
            model.PhoneNumber = TPhone;
            model.Address = TAddress;
            model.Ages = TAges;
        }
    }

    private void ChangingPassword()
    {
        IsChangingPassword = true;
        TPassword = string.Empty;
        TNPassword = string.Empty;
        TCPassword = string.Empty;
    }

    private void SavePassword()
    {
        if (TPassword != model.Password) WrongPass = true;
        else WrongPass = false;

        if ((TNPassword != TCPassword) || (TNPassword.Length <= 4)) Mismatch = true;
        else Mismatch = false;

        if (WrongPass == false && Mismatch == false)
        {
            IsChangingPassword = false;
            model.Password = TNPassword;
        }
    }

    private void CancelChange()
    {
        WrongPass = false;
        Mismatch = false;
        IsChangingPassword = false;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
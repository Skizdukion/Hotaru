#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "badb577982015d204fa84534356475b490fe9cb9"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.ManagerLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/offlinebooking/")]
    public partial class OfflineBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorStrap.BSJumbotron>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSBasicForm>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(9);
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(12);
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(14, "Customer ID:");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n                ");
                        __builder4.OpenElement(16, "div");
                        __builder4.AddAttribute(17, "class", "row");
                        __builder4.AddMarkupContent(18, "\r\n                    ");
                        __Blazor.Hotaru.Pages.Manager.OfflineBooking.TypeInference.CreateBSBasicInput_0(__builder4, 19, 20, "col-12", 21, 
#nullable restore
#line 10 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                            InputType.Text

#line default
#line hidden
#nullable disable
                        , 22, 
#nullable restore
#line 10 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                         CustomerID

#line default
#line hidden
#nullable disable
                        , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CustomerID = __value, CustomerID)));
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(25, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(30);
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(32, "Room select");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                ");
                        __builder4.OpenElement(34, "div");
                        __builder4.AddAttribute(35, "class", "row");
                        __builder4.AddMarkupContent(36, "\r\n                    ");
                        __Blazor.Hotaru.Pages.Manager.OfflineBooking.TypeInference.CreateBSBasicInput_1(__builder4, 37, 38, "col-8", 39, 
#nullable restore
#line 16 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                           InputType.Select

#line default
#line hidden
#nullable disable
                        , 40, 
#nullable restore
#line 16 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                          Room_temp_name

#line default
#line hidden
#nullable disable
                        , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Room_temp_name = __value, Room_temp_name)), 42, (__builder5) => {
                            __builder5.AddMarkupContent(43, "\r\n\r\n");
#nullable restore
#line 18 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                         for (int i = 0; i < model.RoomData_Name.Count; i++)
                        {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(44, "                            ");
                            __builder5.OpenElement(45, "option");
                            __builder5.AddContent(46, 
#nullable restore
#line 20 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                     model.RoomData_Name[i]

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(47, "\r\n");
#nullable restore
#line 21 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                        }

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(48, "\r\n                    ");
                        }
                        );
                        __builder4.AddMarkupContent(49, "\r\n");
#nullable restore
#line 24 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                     for (int i = 0; i < model.RoomData_Name.Count; i++)
                    {
                        if (model.RoomData_Name[i] == Room_temp_name)
                        {
                            Room_temp_locate = i;
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                      
                        if (!string.IsNullOrEmpty(Room_temp_name))
                            Price = model.RoomData_Price[Room_temp_locate].ToString() + " vnđ";
                    

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(50, "                    ");
                        __Blazor.Hotaru.Pages.Manager.OfflineBooking.TypeInference.CreateBSBasicInput_2(__builder4, 51, 52, "col-4", 53, 
#nullable restore
#line 36 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                           InputType.Text

#line default
#line hidden
#nullable disable
                        , 54, 
#nullable restore
#line 36 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                        , 55, 
#nullable restore
#line 36 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                                    Price

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(56, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(57, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(59);
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(62);
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(64, "Date pick room in advance");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n                ");
                        __builder4.OpenElement(66, "div");
                        __builder4.AddAttribute(67, "class", "row");
                        __builder4.AddMarkupContent(68, "\r\n                    ");
                        __Blazor.Hotaru.Pages.Manager.OfflineBooking.TypeInference.CreateBSBasicInput_3(__builder4, 69, 70, "col-12", 71, 
#nullable restore
#line 42 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                            InputType.Date

#line default
#line hidden
#nullable disable
                        , 72, 
#nullable restore
#line 42 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                        , 73, 
#nullable restore
#line 42 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                         datePIA

#line default
#line hidden
#nullable disable
                        , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => datePIA = __value, datePIA)));
                        __builder4.AddMarkupContent(75, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(76, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(78);
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(80, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(81);
                        __builder4.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(83, "Return date expect");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(84, "\r\n                ");
                        __builder4.OpenElement(85, "div");
                        __builder4.AddAttribute(86, "class", "row");
                        __builder4.AddMarkupContent(87, "\r\n                    ");
                        __Blazor.Hotaru.Pages.Manager.OfflineBooking.TypeInference.CreateBSBasicInput_4(__builder4, 88, 89, "col-12", 90, 
#nullable restore
#line 48 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                            InputType.Date

#line default
#line hidden
#nullable disable
                        , 91, 
#nullable restore
#line 48 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                                         dateR

#line default
#line hidden
#nullable disable
                        , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dateR = __value, dateR)));
                        __builder4.AddMarkupContent(93, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(94, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSButton>(96);
                    __builder3.AddAttribute(97, "Class", "p-3");
                    __builder3.AddAttribute(98, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 51 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                        Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 51 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                           Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
                                                                               Booking

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(102, "Confirm");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\OfflineBooking.razor"
       
    DateTime datePIA = DateTime.Now;
    DateTime dateR = DateTime.Now;
    int Room_temp_locate = new int();
    string CustomerID = string.Empty;
    string Room_temp_name = string.Empty;
    string Price = string.Empty;
    Hotel model = new Hotel("Sample name", "129/2A Broadla Coaster Washington DC", "https://r-cf.bstatic.com/images/hotel/max1024x768/231/231141387.jpg", "Our hotel is 5 star rated on Roasted-Tomato, with about more than 1000m2 in space and 60 room of all kind");
    BookingData CT = new BookingData();
    void Booking()
    {
        CT.Room_Name = Room_temp_name;
        CT.Room_Price = model.RoomData_Price[Room_temp_locate];
        CT.DatePickInAdvance = datePIA;
        CT.ReturnDateExpect = dateR;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Hotaru.Pages.Manager.OfflineBooking
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "IsDisabled", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "IsDisabled", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d32b3f2c1e54d54b6a91828f19506828f1f6e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotaru.Pages.User
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
#line 3 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.UserLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/booking/hotel/")]
    public partial class HotelBookingPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorStrap.BSJumbotron>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSCard>(6);
                __builder2.AddAttribute(7, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 7 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                          CardType.Card

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "\r\n\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(10);
                    __builder3.AddAttribute(11, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 9 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                              CardType.Image

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 9 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                 VerticalAlignment.Top

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "src", 
#nullable restore
#line 9 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                                              model.imglink

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(14, "alt", "Card image cap");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(16);
                    __builder3.AddAttribute(17, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 11 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                              CardType.Body

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(20);
                        __builder4.AddAttribute(21, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 13 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                  CardType.Title

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(23, 
#nullable restore
#line 13 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                   model.name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(25);
                        __builder4.AddAttribute(26, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 15 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                  CardType.Subtitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, 
#nullable restore
#line 15 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                      model.address

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSCard>(30);
                        __builder4.AddAttribute(31, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 17 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                  CardType.Text

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(33, "\r\n\r\n                    ");
                            __builder5.AddContent(34, 
#nullable restore
#line 19 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                     model.describe

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(35, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n\r\n\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n\r\n        <hr class=\"my-4\">\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSBasicForm>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(42);
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(44, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(45);
                        __builder4.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(47, "Room select");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n                ");
                        __builder4.OpenElement(49, "div");
                        __builder4.AddAttribute(50, "class", "row");
                        __builder4.AddMarkupContent(51, "\r\n                    ");
                        __Blazor.Hotaru.Pages.User.HotelBookingPage.TypeInference.CreateBSBasicInput_0(__builder4, 52, 53, "col-8", 54, 
#nullable restore
#line 32 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                           InputType.Select

#line default
#line hidden
#nullable disable
                        , 55, 
#nullable restore
#line 32 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                                          Room_temp_name

#line default
#line hidden
#nullable disable
                        , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Room_temp_name = __value, Room_temp_name)), 57, (__builder5) => {
                            __builder5.AddMarkupContent(58, "\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                         for (int i = 0; i < model.RoomData_Name.Count; i++)
                        {

#line default
#line hidden
#nullable disable
                            __builder5.AddContent(59, "                            ");
                            __builder5.OpenElement(60, "option");
                            __builder5.AddContent(61, 
#nullable restore
#line 36 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                     model.RoomData_Name[i]

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(62, "\r\n");
#nullable restore
#line 37 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                        }

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(63, "\r\n                    ");
                        }
                        );
                        __builder4.AddMarkupContent(64, "\r\n");
#nullable restore
#line 40 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
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
#line 48 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                      
                        if (!string.IsNullOrEmpty(Room_temp_name))
                            Price = model.RoomData_Price[Room_temp_locate].ToString() + " vnđ";
                    

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(65, "                    ");
                        __Blazor.Hotaru.Pages.User.HotelBookingPage.TypeInference.CreateBSBasicInput_1(__builder4, 66, 67, "col-4", 68, 
#nullable restore
#line 52 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                           InputType.Text

#line default
#line hidden
#nullable disable
                        , 69, 
#nullable restore
#line 52 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
                        , 70, 
#nullable restore
#line 52 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                                                    Price

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(71, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(72, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSFormGroup>(74);
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(76, "\r\n                ");
                        __builder4.OpenComponent<BlazorStrap.BSLabel>(77);
                        __builder4.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(79, "Date pick room in advance");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(80, "\r\n                ");
                        __builder4.OpenElement(81, "div");
                        __builder4.AddAttribute(82, "class", "row");
                        __builder4.AddMarkupContent(83, "\r\n                    ");
                        __Blazor.Hotaru.Pages.User.HotelBookingPage.TypeInference.CreateBSBasicInput_2(__builder4, 84, 85, "col-12", 86, 
#nullable restore
#line 58 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                            InputType.Date

#line default
#line hidden
#nullable disable
                        , 87, 
#nullable restore
#line 58 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                                                         date

#line default
#line hidden
#nullable disable
                        , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date)));
                        __builder4.AddMarkupContent(89, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(90, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n\r\n            ");
                    __builder3.OpenComponent<BlazorStrap.BSButton>(92);
                    __builder3.AddAttribute(93, "Class", "p-3");
                    __builder3.AddAttribute(94, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 62 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                        Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 62 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
                                                           Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(97, "Booking");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Kazekage\source\repos\Hotaru\Hotaru\Pages\User\HotelBookingPage.razor"
       
    DateTime date = DateTime.Now;
    int Room_temp_locate = new int();
    string Room_temp_name = string.Empty;
    string Price = string.Empty;
    Hotel model = new Hotel("Sample name", "129/2A Broadla Coaster Washington DC", "https://r-cf.bstatic.com/images/hotel/max1024x768/231/231141387.jpg", "Our hotel is 5 star rated on Roasted-Tomato, with about more than 1000m2 in space and 60 room of all kind");

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Hotaru.Pages.User.HotelBookingPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, T __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "IsDisabled", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::BlazorStrap.InputType __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
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

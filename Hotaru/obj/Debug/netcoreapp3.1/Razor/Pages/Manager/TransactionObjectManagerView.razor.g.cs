#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa348663f965fa7eb53ff00fcf594f363c69554"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-4");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<BlazorStrap.BSCard>(9);
            __builder.AddAttribute(10, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 7 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                              CardType.Card

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n\r\n                ");
                __builder2.OpenComponent<BlazorStrap.BSCard>(13);
                __builder2.AddAttribute(14, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 9 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                  CardType.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 9 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                     VerticalAlignment.Top

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "src", "https://upload.wikimedia.org/wikipedia/vi/6/65/Naruto-Opening01_222.jpg");
                __builder2.AddAttribute(17, "alt", "Card image cap");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.OpenComponent<BlazorStrap.BSCard>(19);
                __builder2.AddAttribute(20, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                  CardType.Body

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n\r\n                    ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(23);
                    __builder3.AddAttribute(24, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                      CardType.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(26, 
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                       model.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n\r\n                    ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(28);
                    __builder3.AddAttribute(29, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 15 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                      CardType.Subtitle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, 
#nullable restore
#line 15 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                          model.Ages

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(32, " years old");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                    ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(34);
                    __builder3.AddAttribute(35, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 16 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                      CardType.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-8 pd-20");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<h3>\r\n                <span class=\"mr-2 oi oi-calculator\"></span>\r\n                Accounting\r\n            </h3>\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.AddMarkupContent(47, "<div class=\"col-12 pb-3\">\r\n                    Date pick in advance:\r\n                </div>\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-12 pb-3");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_0(__builder, 51, 52, 
#nullable restore
#line 31 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Date

#line default
#line hidden
#nullable disable
            , 53, 
#nullable restore
#line 31 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
            , 54, 
#nullable restore
#line 31 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                          CT.DatePickInAdvance

#line default
#line hidden
#nullable disable
            , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.DatePickInAdvance = __value, CT.DatePickInAdvance)));
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.AddMarkupContent(58, "<div class=\"col-12 pb-3\">\r\n                    Date return:\r\n                </div>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-12 pb-3");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_1(__builder, 62, 63, 
#nullable restore
#line 37 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Date

#line default
#line hidden
#nullable disable
            , 64, 
#nullable restore
#line 37 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
            , 65, 
#nullable restore
#line 37 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                          CT.DateReturn

#line default
#line hidden
#nullable disable
            , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.DateReturn = __value, CT.DateReturn)));
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.AddMarkupContent(69, "<div class=\"col-12 pb-3\">\r\n                    Room name:\r\n                </div>\r\n                ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-8 pb-3");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_2(__builder, 73, 74, 
#nullable restore
#line 43 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
            , 75, 
#nullable restore
#line 43 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                         true

#line default
#line hidden
#nullable disable
            , 76, 
#nullable restore
#line 43 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                            CT.Room_Name

#line default
#line hidden
#nullable disable
            , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.Room_Name = __value, CT.Room_Name)));
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-4 pb-3");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_3(__builder, 83, 84, 
#nullable restore
#line 46 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
            , 85, 
#nullable restore
#line 46 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                         true

#line default
#line hidden
#nullable disable
            , 86, 
#nullable restore
#line 46 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                      CT.Room_Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.AddMarkupContent(89, "<div class=\"col-12 pb-3\">\r\n                    Additional fee description:\r\n                </div>\r\n                ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-12 pb-3");
            __builder.AddMarkupContent(92, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_4(__builder, 93, 94, 
#nullable restore
#line 52 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.TextArea

#line default
#line hidden
#nullable disable
            , 95, 
#nullable restore
#line 52 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            , 96, 
#nullable restore
#line 52 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                                CT.AddtionalFeeDescription

#line default
#line hidden
#nullable disable
            , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.AddtionalFeeDescription = __value, CT.AddtionalFeeDescription)));
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.AddMarkupContent(100, "<div class=\"col-12 pb-3\">\r\n                    Additional fee(money):\r\n                </div>\r\n                ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "col-12 pb-3");
            __builder.AddMarkupContent(103, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_5(__builder, 104, 105, 
#nullable restore
#line 58 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Number

#line default
#line hidden
#nullable disable
            , 106, 
#nullable restore
#line 58 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            , 107, 
#nullable restore
#line 58 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                              CT.AddtionalFee

#line default
#line hidden
#nullable disable
            , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.AddtionalFee = __value, CT.AddtionalFee)));
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.AddMarkupContent(111, "<div class=\"col-12 pb-3\">\r\n                    Bill price:\r\n                </div>\r\n                ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "col-12 pb-3");
            __builder.AddMarkupContent(114, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView.TypeInference.CreateBSBasicInput_6(__builder, 115, 116, 
#nullable restore
#line 64 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                             InputType.Number

#line default
#line hidden
#nullable disable
            , 117, 
#nullable restore
#line 64 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            , 118, 
#nullable restore
#line 64 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\TransactionObjectManagerView.razor"
                                                                                              CT.BillPrice

#line default
#line hidden
#nullable disable
            , 119, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.BillPrice = __value, CT.BillPrice)));
            __builder.AddMarkupContent(120, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.Hotaru.Pages.Manager.TransactionObjectManagerView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBSBasicInput_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "IsDisabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

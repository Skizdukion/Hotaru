#pragma checksum "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45ddc4d354bd51a17ca3d3ca1cbc962431f3524"
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
#line 3 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
using Hotaru.shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Hotaru.Shared.LayOut.ManagerLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/manager/customeraccounting")]
    public partial class CustomerAccounting : Microsoft.AspNetCore.Components.ComponentBase
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
#line 7 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
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
#line 9 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                  CardType.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "VerticalAlignment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.VerticalAlignment>(
#nullable restore
#line 9 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
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
#line 11 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
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
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                      CardType.Title

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(26, 
#nullable restore
#line 13 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
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
#line 15 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                      CardType.Subtitle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, 
#nullable restore
#line 15 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                          model.Ages

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(32, " years old");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n\r\n                    ");
                    __builder3.OpenComponent<BlazorStrap.BSCard>(34);
                    __builder3.AddAttribute(35, "CardType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.CardType>(
#nullable restore
#line 17 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                      CardType.Text

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(37, "\r\n                        ");
                        __builder4.AddContent(38, 
#nullable restore
#line 18 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                         model.state

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(39, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-8 pd-20");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<h3>\r\n                <span class=\"mr-2 oi oi-calculator\"></span>\r\n                Accounting\r\n            </h3>\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddMarkupContent(51, "<div class=\"col-12 pb-3\">\r\n                    Date pick in advance:\r\n                </div>\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-12 pb-3");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_0(__builder, 55, 56, 
#nullable restore
#line 34 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.Date

#line default
#line hidden
#nullable disable
            , 57, 
#nullable restore
#line 34 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 34 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                          CT.DatePickInAdvance

#line default
#line hidden
#nullable disable
            , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.DatePickInAdvance = __value, CT.DatePickInAdvance)));
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.AddMarkupContent(62, "<div class=\"col-12 pb-3\">\r\n                    Date return:\r\n                </div>\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-12 pb-3");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_1(__builder, 66, 67, 
#nullable restore
#line 40 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.Date

#line default
#line hidden
#nullable disable
            , 68, 
#nullable restore
#line 40 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                          CT.DateReturn

#line default
#line hidden
#nullable disable
            , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.DateReturn = __value, CT.DateReturn)));
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.AddMarkupContent(72, "<div class=\"col-12 pb-3\">\r\n                    Room name:\r\n                </div>\r\n                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-8 pb-3");
            __builder.AddMarkupContent(75, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_2(__builder, 76, 77, 
#nullable restore
#line 46 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.Select

#line default
#line hidden
#nullable disable
            , 78, 
#nullable restore
#line 46 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                            Room_temp_name

#line default
#line hidden
#nullable disable
            , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Room_temp_name = __value, Room_temp_name)), 80, (__builder2) => {
                __builder2.AddMarkupContent(81, "\r\n\r\n");
#nullable restore
#line 48 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                         for (int i = 0; i < ht.RoomData_Name.Count; i++)
                        {
                            int temp = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                            ");
                __builder2.OpenElement(83, "option");
                __builder2.AddContent(84, 
#nullable restore
#line 51 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                     ht.RoomData_Name[temp]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n");
#nullable restore
#line 52 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(86, "\r\n                    ");
            }
            );
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-4 pb-3");
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 57 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                     for (int i = 0; i < ht.RoomData_Name.Count; i++)
                    {
                        int temp = i;
                        if (ht.RoomData_Name[temp] == Room_temp_name)
                        {
                            Room_temp_locate = temp;
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                      
                        if (!string.IsNullOrEmpty(Room_temp_name))
                            Price = ht.RoomData_Price[Room_temp_locate].ToString() + " vnđ";
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_3(__builder, 93, 94, 
#nullable restore
#line 70 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
            , 95, 
#nullable restore
#line 70 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                         true

#line default
#line hidden
#nullable disable
            , 96, 
#nullable restore
#line 70 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                                      Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.AddMarkupContent(99, "<div class=\"col-12 pb-3\">\r\n                    Additional fee description:\r\n                </div>\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-12 pb-3");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_4(__builder, 103, 104, 
#nullable restore
#line 76 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.TextArea

#line default
#line hidden
#nullable disable
            , 105, 
#nullable restore
#line 76 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                              CT.AddtionalFeeDescription

#line default
#line hidden
#nullable disable
            , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.AddtionalFeeDescription = __value, CT.AddtionalFeeDescription)));
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.AddMarkupContent(109, "<div class=\"col-12 pb-3\">\r\n                    Additional fee(money):\r\n                </div>\r\n                ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-12 pb-3");
            __builder.AddMarkupContent(112, "\r\n                    ");
            __Blazor.Hotaru.Pages.Manager.CustomerAccounting.TypeInference.CreateBSBasicInput_5(__builder, 113, 114, 
#nullable restore
#line 82 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                             InputType.Number

#line default
#line hidden
#nullable disable
            , 115, 
#nullable restore
#line 82 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                                            CT.AddtionalFee

#line default
#line hidden
#nullable disable
            , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CT.AddtionalFee = __value, CT.AddtionalFee)));
            __builder.AddMarkupContent(117, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.OpenComponent<BlazorStrap.BSButton>(119);
            __builder.AddAttribute(120, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 84 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                 Color.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 84 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
                                                   Size.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "Class", "float-right");
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(124, "Alert to customer");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "G:\Desktop\project\Hotaru\Hotaru\Pages\Manager\CustomerAccounting.razor"
       
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
namespace __Blazor.Hotaru.Pages.Manager.CustomerAccounting
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
        public static void CreateBSBasicInput_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
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
        public static void CreateBSBasicInput_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateBSBasicInput_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::BlazorStrap.InputType __arg0, int __seq1, T __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg2)
        {
        __builder.OpenComponent<global::BlazorStrap.BSBasicInput<T>>(seq);
        __builder.AddAttribute(__seq0, "InputType", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

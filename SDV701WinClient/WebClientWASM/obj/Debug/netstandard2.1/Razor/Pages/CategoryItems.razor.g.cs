#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3a8990a1a7a0b95e9908302211b9a107b8a17c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebClientWASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 6 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using WebClientWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using WebClientWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
using grpcCalls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
using SDV701common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
using WebClientWASM.infrastructure;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories/{id:int}")]
    public partial class CategoryItems : backHandler
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStyled.Styled>(0);
            __builder.AddAttribute(1, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                          styleContainer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => styleContainer = __value, styleContainer))));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    display: flex;\r\n    flex-direction: column;\r\n    align-items: flex-start;\r\n    justify-content: stretch;\r\n    height: 100%;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<WebClientWASM.Pages.Window>(6);
            __builder.AddAttribute(7, "Caption", "Category items list");
            __builder.AddAttribute(8, "ErrorMSG", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                 lastError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", 
#nullable restore
#line 22 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                 styleContainer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table-auto w-full");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, @"<thead>
                <tr>
                    <th class=""border px-4 py-2"">Name</th>
                    <th class=""border px-4 py-2"">Price</th>
                    <th class=""border px-4 py-2"">In Stock</th>
                    <th class=""border px-4 py-2"">Details</th>
                    <th class=""border px-4 py-2"">Order</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(18, "tbody");
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 34 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                 foreach (var record in lst)
                {
                    string qtyStyle = "";
                    if (record.QtyInStock > 0) qtyStyle = "background-color:#C8463F;";
                    if (record.QtyInStock > 3) qtyStyle = "background-color:#EC6A00;";
                    if (record.QtyInStock > 5) qtyStyle = "background-color:green;";
                    string navRoute = $"/oderitem/{@record.id}";

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "                    ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "td");
                __builder2.AddAttribute(24, "class", "border px-4 py-2");
                __builder2.AddContent(25, 
#nullable restore
#line 42 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                      record.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenElement(27, "td");
                __builder2.AddAttribute(28, "class", "border px-4 py-2");
                __builder2.AddContent(29, 
#nullable restore
#line 43 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                      record.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(30, " ");
                __builder2.AddContent(31, 
#nullable restore
#line 43 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                                    record.Currency

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "td");
                __builder2.AddAttribute(34, "class", "border px-4 py-2");
                __builder2.OpenElement(35, "p");
                __builder2.AddAttribute(36, "style", 
#nullable restore
#line 44 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                                qtyStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(37, " ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.OpenElement(39, "td");
                __builder2.AddAttribute(40, "class", "border px-4 py-2");
                __builder2.AddContent(41, 
#nullable restore
#line 45 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                       (MarkupString)record.ReturnOODetails().Replace("\r\n","<br>")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "td");
                __builder2.AddAttribute(44, "class", "border px-4 py-2");
                __builder2.AddMarkupContent(45, "\r\n                            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "flex justify-center");
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
                __builder2.AddAttribute(50, "class", "inline-block border border-white rounded hover:border-gray-200 text-blue-500 hover:bg-gray-200 py-1 px-3");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                                                                                                                                                                      e=> { State.SelectedPart = record; NavigateWithHistory(navRoute, $"/categories/{id}", NavigationManager); }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Order now");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 52 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategoryItems.razor"
       
    [Parameter]
    public int id { get; set; }

    private string styleContainer;
    private string lastError = "";
    private List<NPart> lst = new List<NPart>();

    protected override async void OnInitialized()
    {
        WebClientWASM.infrastructure.State.previousPage = "/category";
        lastError = "";
        try
        {
            lst = (await gRPCClient.GetListOfPartsByCategoryId<NPart>(id)).FindAll(x => x.QtyInStock > 0);
            lastError = "";
        }
        catch (Exception e)
        {
            lastError = e.GetBaseException().Message;
        }
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

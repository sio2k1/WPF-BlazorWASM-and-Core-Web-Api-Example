#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91af63f0172a7b1802b7380058a8034eb4770d1c"
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
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
using grpcCalls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
using SDV701common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
using WebClientWASM.infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
using WebClientWASM.components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/oderitem/{id:int}")]
    public partial class OrderItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStyled.Styled>(0);
            __builder.AddAttribute(1, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                          styleContainer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => styleContainer = __value, styleContainer))));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    display: grid;\r\n    grid-template-areas:\r\n    \'ordertable ordertable\'\r\n    \'clientdetails order\'\r\n    \'confirmation confirmation\';\r\n    grid-gap: 10px;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, @"
    .order-placement-table {
        grid-area: ordertable;
    }

    .order-placement-client-details {
        grid-area: clientdetails;
    }

    .order-placement-order {
        grid-area: order;
    }

    .order-confirmation {
        grid-area: confirmation;
    }
");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<WebClientWASM.Pages.Window>(10);
            __builder.AddAttribute(11, "Caption", "Order Placement");
            __builder.AddAttribute(12, "ErrorMSG", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                             lastError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
                __builder2.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                      OFM

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                          OnSubmitClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n\r\n        ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", 
#nullable restore
#line 42 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                     styleContainer

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "order-placement-table");
                    __builder3.AddMarkupContent(27, "\r\n                ");
                    __builder3.OpenElement(28, "table");
                    __builder3.AddAttribute(29, "class", "table-auto w-full m-1");
                    __builder3.AddMarkupContent(30, "\r\n                    ");
                    __builder3.AddMarkupContent(31, @"<thead>
                        <tr>
                            <th class=""border px-4 py-2"">Name</th>
                            <th class=""border px-4 py-2"">Details</th>
                            <th class=""border px-4 py-2"">Price</th>
                            <th class=""border px-4 py-2"">Quantity</th>
                            <th class=""border px-4 py-2"">Total</th>
                        </tr>
                    </thead>
                    ");
                    __builder3.OpenElement(32, "tbody");
                    __builder3.AddMarkupContent(33, "\r\n                        ");
                    __builder3.OpenElement(34, "tr");
                    __builder3.AddMarkupContent(35, "\r\n                            ");
                    __builder3.OpenElement(36, "td");
                    __builder3.AddAttribute(37, "class", "border px-4 py-2");
                    __builder3.AddContent(38, 
#nullable restore
#line 56 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                          part.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n                            ");
                    __builder3.OpenElement(40, "td");
                    __builder3.AddAttribute(41, "class", "border px-4 py-2");
                    __builder3.AddContent(42, 
#nullable restore
#line 57 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                           (MarkupString)part.ReturnOODetails().Replace("\r\n","<br>")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n                            ");
                    __builder3.OpenElement(44, "td");
                    __builder3.AddAttribute(45, "class", "border px-4 py-2");
                    __builder3.AddContent(46, 
#nullable restore
#line 58 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                          part.Price

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, " ");
                    __builder3.AddContent(48, 
#nullable restore
#line 58 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                      part.Currency

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n                            ");
                    __builder3.OpenElement(50, "td");
                    __builder3.AddAttribute(51, "class", "border px-4 py-2");
                    __builder3.OpenElement(52, "input");
                    __builder3.AddAttribute(53, "disabled", 
#nullable restore
#line 59 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                           IsDisabled

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(54, "class", "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline");
                    __builder3.AddAttribute(55, "min", "1");
                    __builder3.AddAttribute(56, "max", 
#nullable restore
#line 59 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                                                                                         part.QtyInStock

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(57, "type", "number");
                    __builder3.AddAttribute(58, "placeholder", "");
                    __builder3.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                                                                  OFM.Qty

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => OFM.Qty = __value, OFM.Qty, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                            ");
                    __builder3.OpenElement(62, "td");
                    __builder3.AddAttribute(63, "class", "border px-4 py-2");
                    __builder3.AddContent(64, 
#nullable restore
#line 60 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                           part.Price*OFM.Qty

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(65, " ");
                    __builder3.AddContent(66, 
#nullable restore
#line 60 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                part.Currency

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "order-placement-client-details flex w-2/4");
                    __builder3.AddMarkupContent(74, "\r\n                ");
                    __builder3.OpenElement(75, "input");
                    __builder3.AddAttribute(76, "disabled", 
#nullable restore
#line 66 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                  IsDisabled

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(77, "class", "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline m-1");
                    __builder3.AddAttribute(78, "type", "text");
                    __builder3.AddAttribute(79, "placeholder", "Client Name");
                    __builder3.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                             OFM.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => OFM.Name = __value, OFM.Name));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\r\n                ");
                    __builder3.OpenElement(83, "input");
                    __builder3.AddAttribute(84, "disabled", 
#nullable restore
#line 67 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                  IsDisabled

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(85, "class", "shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline m-1");
                    __builder3.AddAttribute(86, "type", "text");
                    __builder3.AddAttribute(87, "placeholder", "Client E-Mail");
                    __builder3.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                             OFM.EmailAddress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => OFM.EmailAddress = __value, OFM.EmailAddress));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "order-placement-order flex justify-end");
                    __builder3.AddMarkupContent(94, "\r\n");
#nullable restore
#line 70 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                 if (!IsDisabled)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(95, "                    ");
                    __builder3.AddMarkupContent(96, "<button type=\"submit\" class=\"bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded m-1\">\r\n                        Confirm\r\n                    </button>\r\n");
#nullable restore
#line 75 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(97, "                    ");
                    __builder3.AddMarkupContent(98, "<button type=\"submit\" class=\"bg-blue-500 text-white font-bold py-2 px-4 rounded opacity-50 cursor-not-allowed\">\r\n                        Confirm\r\n                    </button>\r\n");
#nullable restore
#line 81 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(99, "            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\r\n");
#nullable restore
#line 83 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
             if (newOrderId != -1) //Order confirmation message
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(101, "                ");
                    __builder3.OpenElement(102, "div");
                    __builder3.AddAttribute(103, "class", "order-confirmation");
                    __builder3.AddMarkupContent(104, "\r\n                    ");
                    __builder3.OpenComponent<WebClientWASM.components.ConfirmationMessage>(105);
                    __builder3.AddAttribute(106, "Title", "Your order placed successfully");
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(108, "Your order number is ");
                        __builder4.OpenElement(109, "b");
                        __builder4.AddContent(110, "#");
                        __builder4.AddContent(111, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                          newOrderId

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(112, "<br>");
                        __builder4.OpenElement(113, "b");
                        __builder4.AddContent(114, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                part.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddContent(115, " ");
                        __builder4.AddContent(116, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                               OFM.Qty

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(117, " pcs. Total: ");
                        __builder4.OpenElement(118, "b");
                        __builder4.AddContent(119, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                        part.Price*OFM.Qty

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(120, " ");
                        __builder4.AddContent(121, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                             part.Currency

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(122, "<br>Client name: ");
                        __builder4.OpenElement(123, "b");
                        __builder4.AddContent(124, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                                                                   OFM.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(125, "<br>Client e-mail: ");
                        __builder4.OpenElement(126, "b");
                        __builder4.AddContent(127, 
#nullable restore
#line 86 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
                                                                                                                                                                                                                                                                      OFM.EmailAddress

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(128, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\r\n");
#nullable restore
#line 88 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(130, "        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(132);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(134, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\OrderItem.razor"
       
    [Parameter]
    public int id { get; set; }

    private string styleContainer;
    private string lastError = "";
    private NPart part = new NEmptyPart();
    private OrderFormModel OFM = new OrderFormModel();
    private int newOrderId = -1;
    private bool IsDisabled = false;

    private void OnQtyChange()
    {
        this.StateHasChanged();
    }

    private async void OnSubmitClick()
    {
        if (!IsDisabled)
        {
            try
            {
                newOrderId = await gRPCClient.PlaceOrder(part.id, OFM.Qty, OFM.Name, OFM.EmailAddress);
                IsDisabled = true;
                lastError = "";
            }
            catch (Exception e)
            {
                lastError = e.GetBaseException().Message;
            }
            this.StateHasChanged();
        }
    }

    protected override async void OnInitialized()
    {
        bool refreshData = false;

        if (State.SelectedPart != null)
        {
            if (State.SelectedPart.id == id)
            {
                part = State.SelectedPart;
                this.StateHasChanged();
            }
            else
                refreshData = true;
        }
        else
            refreshData = true;

        if (refreshData) //if there was no part in previous state
        {
            try
            {
                State.SelectedPart = await gRPCClient.GetPartsById(id);
                part = State.SelectedPart;
                lastError = "";
            }
            catch (Exception e)
            {
                lastError = e.GetBaseException().Message;
            }
            this.StateHasChanged();
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe295e7a73382528c48f6eea778cd7c137565391"
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
#line 6 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
using WebClientWASM.infrastructure;

#line default
#line hidden
#nullable disable
    public partial class Window : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
             mainContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", 
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                 window

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                     header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 10 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                         caption

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddContent(12, 
#nullable restore
#line 11 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                 Caption

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 14 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                     content

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, 
#nullable restore
#line 14 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                               ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 15 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
         if (!string.IsNullOrEmpty(ErrorMSG))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", 
#nullable restore
#line 17 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                         error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "role", "alert");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddMarkupContent(27, "<div class=\"bg-red-500 text-white font-bold rounded-t px-4 py-2\">\r\n                        Error\r\n                    </div>\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "border border-t-0 border-red-400 rounded-b bg-red-100 px-4 py-3 text-red-700");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, 
#nullable restore
#line 23 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                            ErrorMSG

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 27 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", 
#nullable restore
#line 28 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                     nav

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 29 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
             if (!string.IsNullOrEmpty(State.previousPage))
            {
                string url = State.previousPage;

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "href", 
#nullable restore
#line 32 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                                url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.AddMarkupContent(46, "<button class=\"bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded\">\r\n                        Back\r\n                    </button>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 37 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(52);
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\r\n    a {\r\n        cursor: pointer;\r\n    }\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(56);
            __builder.AddAttribute(57, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          caption

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => caption = __value, caption))));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n    margin: 1rem;\r\n    font-size: large;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(62);
            __builder.AddAttribute(63, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          mainContainer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mainContainer = __value, mainContainer))));
            __builder.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(66, "\r\n    background-color: rgb(224, 231, 231);;\r\n    min-height: 100vh;\r\n    display: flex;\r\n    align-items: center;\r\n    justify-content: center;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(68);
            __builder.AddAttribute(69, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          window

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => window = __value, window))));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, @"
    display: flex;
    flex-direction: column;
    /*grid-template-rows: 50px auto 80px 80px;*/
    background-color: white;
    border-radius: 1rem;
    min-width: 1024px;
    width: 1024px;
    min-height: 576px;
    box-shadow: 3px 4px 28px -3px rgba(0, 0, 0, 0.67);
");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(74);
            __builder.AddAttribute(75, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          header

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => header = __value, header))));
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n    grid-row: 1;\r\n    background-color: rgb(90, 121, 151);\r\n    border-top-left-radius: 1rem;\r\n    border-top-right-radius: 1rem;\r\n    color: aliceblue;\r\n    flex-basis:50px;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(80);
            __builder.AddAttribute(81, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => content = __value, content))));
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(84, "\r\n    margin: 1rem;\r\n    flex: 1;\r\n    grid-row: 2;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(86);
            __builder.AddAttribute(87, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => error = __value, error))));
            __builder.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(90, "\r\n    margin: 1rem;\r\n    flex-basis:80px;\r\n    grid-row: 3;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(92);
            __builder.AddAttribute(93, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
                          nav

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nav = __value, nav))));
            __builder.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(96, "\r\n    grid-row: 4;\r\n    flex-basis:50px;\r\n    margin: 1rem;\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\Window.razor"
       
    [Parameter]
    public string ErrorMSG { get; set; }
    [Parameter]
    public string Caption { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string mainContainer;
    private string window;
    private string header;
    private string caption;
    private string content;
    private string error;
    private string nav;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

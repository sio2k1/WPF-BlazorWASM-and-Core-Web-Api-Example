#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96ac716479260c901ced30f3329911829ca8ee5"
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
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
using grpcCalls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
using SDV701common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class CategorySelection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStyled.Styled>(0);
            __builder.AddAttribute(1, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                          styleContainer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => styleContainer = __value, styleContainer))));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    display: flex;\r\n    height: 100%;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<BlazorStyled.Styled>(6);
            __builder.AddAttribute(7, "Classname", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                          navLinkStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ClassnameChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => navLinkStyle = __value, navLinkStyle))));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    margin:10px;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<WebClientWASM.Pages.Window>(12);
            __builder.AddAttribute(13, "Caption", "Category selection");
            __builder.AddAttribute(14, "ErrorMSG", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                                                lastError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", 
#nullable restore
#line 21 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                 styleContainer

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 22 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
         foreach (var record in lst)
        {
            string navRoute = $"/categories/{@record.id}";

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
                __builder2.AddAttribute(22, "class", 
#nullable restore
#line 25 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                             navLinkStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(23, "href", 
#nullable restore
#line 25 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                                                  navRoute

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "max-w-sm rounded overflow-hidden shadow-lg hover:bg-gray-100");
                    __builder3.AddMarkupContent(28, "\r\n                    ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "px-6 py-4");
                    __builder3.AddMarkupContent(31, "\r\n                        ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "class", "font-bold text-xl mb-2");
                    __builder3.AddContent(34, 
#nullable restore
#line 28 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                                                             record.Categoryname

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                        ");
                    __builder3.OpenElement(36, "p");
                    __builder3.AddAttribute(37, "class", "text-gray-700 text-base");
                    __builder3.AddMarkupContent(38, "\r\n                            ");
                    __builder3.AddContent(39, 
#nullable restore
#line 30 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
                             record.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(40, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 35 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(45, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\@SkyDrive\SkyDrive\@backup\@nmit\SDV701\A2\SDV701WinClient\WebClientWASM\Pages\CategorySelection.razor"
       
    private string styleContainer;
    private string navLinkStyle;
    private string lastError = "";
    private List<Category> lst = new List<Category>();

    private async Task getNSaveLst(string hash)
    {
        lst = await gRPCClient.GetListOfCategories();
        await localStorage.SetItemAsync("catData", lst);
        await localStorage.SetItemAsync("catHash", hash);
    }

    protected override async void OnInitialized()
    {
        WebClientWASM.infrastructure.State.previousPage = "/";
        lastError = "";
        try
        {
            string currentHash = await localStorage.GetItemAsync<string>("catHash");
            string hash = await gRPCClient.GetCategoriesHash();

            if (currentHash == hash)
            {
                //load from local storage
                try
                {
                    lst = await localStorage.GetItemAsync<List<Category>>("catData");
                    if (lst == null)
                        throw new Exception("Lst is empty");
                }
                catch
                {
                    await getNSaveLst(hash);
                }
            }
            else
            {
                await getNSaveLst(hash);
            }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591

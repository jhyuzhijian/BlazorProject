#pragma checksum "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6d79f98568447dfa5e111be4328c0cea54216e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Entity.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity;

#line default
#line hidden
#line 9 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Shared;

#line default
#line hidden
#line 10 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Component;

#line default
#line hidden
#line 12 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#line 13 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#line 14 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#line 15 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#line 16 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#line 17 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#line 18 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#line 19 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#line 20 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#line 21 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#line 22 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#line 23 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#line 24 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#line 25 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#line 26 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorApp_Entity</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#line 8 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 11 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "counter");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "fetchdata");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "G:\Git\Blazor\BlazorApp_Entity\BlazorApp_Entity\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

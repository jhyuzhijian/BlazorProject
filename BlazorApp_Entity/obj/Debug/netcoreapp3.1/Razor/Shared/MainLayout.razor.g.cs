#pragma checksum "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da7ae334d560e2e03b5e95799357c4907ad83f9"
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
#nullable restore
#line 1 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazui.Component.Popup.BPopup>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorApp_Entity.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/en-us/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<p>componentMainLayout Default Route</p>\r\n        ");
            __builder.AddContent(16, 
#nullable restore
#line 15 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9620b8b308a425f856ccd5554427c629e1f1d8ea"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Entity.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using BlazorApp_Entity.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Container;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Button;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Radio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Select;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.CheckBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Switch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Table;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Popup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "G:\Git\BlazorProject\BlazorApp_Entity\_Imports.razor"
using Blazui.Component;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Child Component</h2>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Year:");
            __builder.AddContent(3, 
#nullable restore
#line 3 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
         Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "panel panel-default");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "panel-heading");
            __builder.AddContent(10, 
#nullable restore
#line 5 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "panel-body");
            __builder.AddMarkupContent(14, "\"内容：");
            __builder.AddContent(15, 
#nullable restore
#line 6 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
                                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
                                              OnClickMy

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n        触发父组件方法\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.AddContent(22, 
#nullable restore
#line 11 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
      (MarkupString)myMarkup

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "G:\Git\BlazorProject\BlazorApp_Entity\Component\ChildComponent.razor"
       
    private string myMarkup = "<button class='btn btn-primary'>html按钮</button>";
    private string message { get; set; } = "我是初始值";
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public int Year { get; set; }

    public EventCallback<int> YearChanged { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnClickMy { get; set; }
    private void UpdateHeading(MouseEventArgs e, int buttonNumber)
    {
        message = $"You selected Button #{buttonNumber} at " +
            $"mouse position: {e.ClientX} X {e.ClientY}.";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Component\PasswordField.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e660144088f5ce3953e870270d60e2fb8e95db7c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Entity.Component
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
    public partial class PasswordField : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Component\PasswordField.razor"
       
    private string validateMsg { get; set; } = "";
    private bool showPassword;

    [Parameter]
    public string PasswordMyself { get; set; }

    [Parameter]
    public EventCallback<string> PasswordMyselfChanged
    { get; set; }

    private Task OnPasswordChanged(ChangeEventArgs e)
    {
        PasswordMyself = e.Value.ToString();
        if (PasswordMyself.Contains(" "))
        {
            validateMsg = "密码包含空格，请注意";
        }
        else { validateMsg = ""; }

        return PasswordMyselfChanged.InvokeAsync(PasswordMyself);
    }

    private void ToggleShowPassword()
    {
        showPassword = !showPassword;
    }
    public void Show()
    {
        PasswordMyselfChanged.InvokeAsync("show");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

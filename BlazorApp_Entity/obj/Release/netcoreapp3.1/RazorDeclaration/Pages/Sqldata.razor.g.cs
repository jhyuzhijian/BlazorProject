#pragma checksum "G:\Git\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1794705830ebb9e03499354d8aabe7dd72532977"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Entity.Pages
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
#nullable restore
#line 2 "G:\Git\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
using BlazorApp_Entity.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sqldata")]
    public partial class Sqldata : Data.SqlConnect
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "G:\Git\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
       
    [Parameter]
    public string IpAdress { get; set; } = "127.0.0.1";
    [Parameter]
    public string Port { get; set; } = "3306";
    [Parameter]
    public string Account { get; set; } = "root";
    [Parameter]
    public string Password { get; set; } = "123456";
    [Inject]
    MessageService MessageService { get; set; }

    public void connectionDb()
    {

        tables = GetDatabaseList(new ConnectionInfo { Account = Account, IpAdress = IpAdress, Port = Port, Pwd = Password });
    }

    protected override void OnInitialized()
    {
        tables = GetDatabaseList(new ConnectionInfo { Account = Account, IpAdress = IpAdress, Port = Port, Pwd = Password });
    }
    public void ShowDetail(object testData)
    {
        MessageService.Show($"正在编辑 " + ((TableInfo)testData).TableName);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0da9f25182b3e681719c034696dd4e4192d81c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Entity.Pages
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
#nullable restore
#line 2 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
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
            __builder.AddMarkupContent(0, "<h3>Sqldata</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    服务器地址：");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "placeholder", "服务器地址");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                  Server

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Server = __value, Server));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    数据库名称：");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "数据库名称");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                  Database

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Database = __value, Database));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\r\n    Account:");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "placeholder", "账号");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                 Account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Account = __value, Account));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    Password:");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "密码");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                  Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                          connectionDb

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "连接数据库");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 14 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
 if (tables == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.AddMarkupContent(33, "<p><em>请填写数据库信息</em></p>\r\n");
#nullable restore
#line 17 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.OpenComponent<Blazui.Component.Table.BTable>(35);
            __builder.AddAttribute(36, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                        tables

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Total", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                       tables.Count

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                                                               pageSize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                                        CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "CurrentPageChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentPage = __value, CurrentPage))));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<Blazui.Component.Table.BTableColumns>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __builder3.OpenComponent<Blazui.Component.Table.BTableTemplateColumn>(46);
                    __builder3.AddAttribute(47, "Text", "操作");
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(49, "\r\n                ");
                        __builder4.OpenComponent<Blazui.Component.Button.BButton>(50);
                        __builder4.AddAttribute(51, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazui.Component.Button.ButtonType>(
#nullable restore
#line 23 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                ButtonType.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazui.Component.Button.ButtonSize>(
#nullable restore
#line 23 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                           ButtonSize.Mini

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(53, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                                                       e=> ShowDetail(context)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, "查看详细");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(59, (__value) => {
#nullable restore
#line 20 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
                                                                                                               table = (Blazui.Component.Table.BTable)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 27 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\DotNet\BlazorApp20200105\DotNet\BlazorProject\BlazorApp_Entity\Pages\Sqldata.razor"
       
    [Parameter]
    public string Server { get; set; } = "LAPTOP-FG0SOM1N";
    [Parameter]
    public string Account { get; set; } = "sa";
    [Parameter]
    public string Password { get; set; } = "123";
    [Parameter]
    public string Database { get; set; } = "test";
    [Inject]
    MessageService MessageService { get; set; }

    public void connectionDb()
    {

        tables = GetDatabaseList(new ConnectionInfo { Account = Account, Server = Server, Database = Database, Pwd = Password });
    }

    protected override void OnInitialized()
    {
        tables = new List<TableInfo>();
    }
    public async Task ShowDetail(object testData)
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("TableName", ((TableInfo)testData).TableName);
        parameters.Add("DBServer", DBServer);
        var result = await _DialogService.ShowDialogAsync<Property>("表详细属性", parameters);
        MessageService.Show(result.ToString());
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

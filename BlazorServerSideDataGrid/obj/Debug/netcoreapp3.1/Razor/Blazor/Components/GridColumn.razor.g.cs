#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30954c2712f0bde2dffde3d829bd01b6e62bebb5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSideDataGrid.Blazor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using BlazorServerSideDataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using BlazorServerSideDataGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using BlazorServerSideDataGrid.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using BlazorServerSideDataGrid.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    public partial class GridColumn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "th");
            __builder.AddAttribute(1, "scope", "col");
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
     if (ColumnDefinition.Sortable)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                     () => OnSort.InvokeAsync(ColumnDefinition.DataField)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-2");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                 if (ColumnDefinition.SortDirection == SortDirection.NotSet)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                                                                                   
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "i");
            __builder.AddAttribute(13, "class", "sort" + " " + (
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                     ColumnDefinition.SortDirection.ToString().ToLower()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-10 text-center");
            __builder.AddContent(19, 
#nullable restore
#line 16 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                             ColumnDefinition.ColumnTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 18 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row col-12 text-center");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                             ColumnDefinition.ColumnTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 22 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 24 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
     if (ColumnDefinition.Searchable)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row col-12");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", 
#nullable restore
#line 27 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                                                  ColumnDefinition.PlaceHolder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
                                                                                                          OnSearchTextChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 29 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\GridColumn.razor"
       
    [Parameter] public ColumnDefinition ColumnDefinition { get; set; }
    [Parameter] public EventCallback<ChangeEventArgs> OnSearchTextChanged { get; set; }
    [Parameter] public EventCallback<string> OnSort { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba594036078a3f3cf7f79d54896cda08acb5fa06"
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
    public partial class TableInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddMarkupContent(1, "\r\n    Showing items ");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
                    (((CurrentPage - 1) * PageSize) + 1).ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    to\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
      (FilteredItemsCount >= PageSize ? (((CurrentPage - 1) * PageSize) + PageSize) : FilteredItemsCount).ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n    -\r\n    Page ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
          CurrentPage.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " of ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
                                         TotalPages.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    -\r\n    ");
            __builder.AddContent(10, 
#nullable restore
#line 8 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
      (FilteredItemsCount >= PageSize ? (TotalPages * PageSize) : FilteredItemsCount).ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n    items filtered from ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
                          ItemsCount.ToString("n0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " items\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableInfo.razor"
       
    [Parameter] public int CurrentPage { get; set; }
    [Parameter] public int PageSize { get; set; }
    [Parameter] public int FilteredItemsCount { get; set; }
    [Parameter] public int TotalPages { get; set; }
    [Parameter] public int ItemsCount { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
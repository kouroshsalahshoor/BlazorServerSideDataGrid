#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8119fbd846d5002073ef644a6c35a2ba528d8ddd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TableTemplate<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Blazor\Components\TableTemplate.razor"
       
    [Parameter] public RenderFragment TableHeader { get; set; }
    [Parameter] public RenderFragment<TItem> RowTemplate { get; set; }
    [Parameter] public IReadOnlyList<TItem> Items { get; set; }

    [Parameter] public int TotalNbrOfItems { get; set; }
    [Parameter] public int CurrentPage { get; set; }
    [Parameter] public int TotalNbrOfPages { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

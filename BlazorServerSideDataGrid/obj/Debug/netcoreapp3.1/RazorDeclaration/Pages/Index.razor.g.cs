#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4fc5b9b50b4cbdd5327cd77311e127c9798c60"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerSideDataGrid.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\k.salahshoor\Desktop\BlazorServerSideDataGrid\BlazorServerSideDataGrid\Pages\Index.razor"
      
    private List<Employee> Items { get; set; } = new List<Employee>();
    private List<Employee> FilteredItems { get; set; } = new List<Employee>();

    private List<ColumnDefinition> ColumnDefinitions { get; set; } = new List<ColumnDefinition>();

    //private int rowCount = 1;

    private int currentPage = 1;
    private int pageSize = 100;
    public int PageSize
    {
        get { return pageSize; }
        set {
            pageSize = value;

            currentPage = 1;
            load();
        }
    }

    private int totalPages = 0;
    private int radius = 3;

    private bool isLoaded = false;

    protected override void OnInitialized()
    {
        ColumnDefinitions.Add(new ColumnDefinition { DataField = "FirstName", ColumnTitle = "First Name", PlaceHolder = "Search First Name", Searchable = true, Sortable = true });
        ColumnDefinitions.Add(new ColumnDefinition { DataField = "LastName", ColumnTitle = "Last Name", PlaceHolder = "Search Last Name", Searchable = true, Sortable = true });

        base.OnInitialized();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Task.Run(() => longRunningOperation());

            isLoaded = true;

            StateHasChanged();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private void longRunningOperation()
    {
        //seed data
        if (Items == null || !Items.Any())
        {
            Items = new List<Employee>();
            for (int i = 1; i <= 10000000; i++)
            //for (int i = 1; i <= 1000; i++)
            {
                Items.Add(new Employee { Id = i, FirstName = "First Name " + i.ToString(), LastName = "Last Name " + i.ToString(), });
            }
        }

        var query = Items.AsQueryable();

        totalPages = (int)Math.Ceiling(query.Count() / (decimal)pageSize);

        FilteredItems = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
    }

    private void onFilter(ChangeEventArgs e, ColumnDefinition columnDefinition)
    {
        string searchText = e.Value.ToString();

        columnDefinition.SearchText = searchText;

        currentPage = 1;

        load();
    }

    private void OnPageChanged(int pageNumber)
    {
        if (pageNumber < 1)
            currentPage = 1;
        else if (pageNumber > totalPages)
            currentPage = totalPages;
        else
            currentPage = pageNumber;

        load();
    }

    private void OnSort(string dataField)
    {
        var columnDefinition = ColumnDefinitions.SingleOrDefault(x => x.DataField == dataField);
        if (columnDefinition.SortDirection == SortDirection.NotSet)
        {
            columnDefinition.SortDirection = SortDirection.Asc;
        }
        else if (columnDefinition.SortDirection == SortDirection.Asc)
        {
            columnDefinition.SortDirection = SortDirection.Desc;
        }
        else if (columnDefinition.SortDirection == SortDirection.Desc)
        {
            columnDefinition.SortDirection = SortDirection.Asc;
        }

        //reset other
        var columnDefinitions = ColumnDefinitions.Where(x => x.DataField != dataField).ToList();
        columnDefinitions.ForEach(x => x.SortDirection = SortDirection.NotSet);

        load();
    }

    private void load()
    {
        var query = Items.AsQueryable();

        //filter
        foreach (var columnDefinition in ColumnDefinitions)
        {
            if (columnDefinition.DataField == "FirstName")
            {
                if (!string.IsNullOrEmpty(columnDefinition.SearchText))
                {
                    query = query.Where(x => x.FirstName.ToLower().Contains(columnDefinition.SearchText.ToLower()));
                }
            }
            else if (columnDefinition.DataField == "LastName")
            {
                if (!string.IsNullOrEmpty(columnDefinition.SearchText))
                {
                    query = query.Where(x => x.LastName.ToLower().Contains(columnDefinition.SearchText.ToLower()));
                }
            }
        }

        //sort
        var sortedColumn = ColumnDefinitions.SingleOrDefault(x => x.SortDirection != SortDirection.NotSet);

        if (sortedColumn != null)
        {
            if (sortedColumn.DataField == "FirstName")
            {
                if (sortedColumn.SortDirection == SortDirection.Asc)
                {
                    query = query.OrderBy(x => x.FirstName);
                }
                else if (sortedColumn.SortDirection == SortDirection.Desc)
                {
                    query = query.OrderByDescending(x => x.FirstName);
                }
            }
            else if (sortedColumn.DataField == "LastName")
            {
                if (sortedColumn.SortDirection == SortDirection.Asc)
                {
                    query = query.OrderBy(x => x.LastName);
                }
                else if (sortedColumn.SortDirection == SortDirection.Desc)
                {
                    query = query.OrderByDescending(x => x.LastName);
                }
            }
        }

        //result
        FilteredItems = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

        totalPages = (int)Math.Ceiling(query.Count() / (decimal)pageSize);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

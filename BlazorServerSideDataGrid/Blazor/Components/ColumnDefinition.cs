using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSideDataGrid.Blazor.Components
{
    public class ColumnDefinition
    {
        public string DataField { get; set; }
        public string ColumnTitle { get; set; }
        public string PlaceHolder { get; set; }

        public bool Sortable { get; set; }
        public SortDirection SortDirection { get; set; }

        public bool Searchable { get; set; }
        public string SearchText { get; set; }
    }

    public enum SortDirection
    {
        NotSet,
        Asc,
        Desc
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionsTestRicardo.Models
{
    public class FilterVM
    {
        public List<FilterItem> Items { get; set; }
        public int? SelectedValue { get; set; }

        public FilterVM()
        {
            Items = new List<FilterItem>();
            Items.Add(new FilterItem { userId = null, id = null, title = "Select" });
        }
    }

    public class FilterItem
    {
        public int? userId { get; set; }
        public int? id { get; set; }
        public string title { get; set; }
    }
}
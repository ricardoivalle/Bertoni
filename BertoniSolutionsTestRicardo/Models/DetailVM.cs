using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionsTestRicardo.Models
{


    public class DetailVM
    {
        public List<DetailItem> Items { get; set; }
        public DetailVM()
        {
            Items = new List<DetailItem>();
        }

    }

    public class DetailItem
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}
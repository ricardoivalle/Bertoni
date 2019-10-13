using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionsTestRicardo.Models
{

    public class ResultsVM
    {
        public List<ResultItem> Items { get; set; }
        public ResultsVM()
        {
            Items = new List<ResultItem>();
        }
       
    }

    public class ResultItem
    {
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
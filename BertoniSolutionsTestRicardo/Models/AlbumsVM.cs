using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionsTestRicardo.Models
{
    /// <summary>
    /// Main class that contains the models for the 3 sections of the view.
    /// </summary>
    public class AlbumsVM
    {
        public AlbumsVM()
        {
            Filter = new FilterVM();
            Results = new ResultsVM();
            Detail = new DetailVM();
        }
        public FilterVM Filter { get; set; }
        public ResultsVM Results { get; set; }
        public DetailVM Detail { get; set; }
        public ErrorsVM Errors { get; set; }
    }
}
using BertoniSolutionsTestRicardo.Models;
using ExternalServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BertoniSolutionsTestRicardo.Controllers
{
    public class HomeController : Controller
    {
        #region Consts
        private const string AlbumsURL = "https://jsonplaceholder.typicode.com/albums";
        private const string PhotosUrl = "https://jsonplaceholder.typicode.com/photos";
        private const string CommentsUrl = "https://jsonplaceholder.typicode.com/comments";
        #endregion

        public ActionResult Index()
        {
            AlbumsVM viewModel = new AlbumsVM();
            return View(viewModel);
        }


        public ActionResult LoadFilterData()
        {
            AlbumsVM model = new AlbumsVM();
            try
            {
                var response = ServiceHelper.Get(AlbumsURL).Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<List<FilterItem>>(response.Result);
                items.ForEach(it => model.Filter.Items.Add(it));
            }
            catch (Exception ex)
            {
                //TODO: Log exception here.
            }
            finally
            {

            }
            return View("_Filter", model);

        }

        public ActionResult LoadResults(int? id)
        {
            AlbumsVM model = new AlbumsVM();
            try
            {
                if (id.HasValue)
                {
                    var response = ServiceHelper.Get(PhotosUrl).Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<List<ResultItem>>(response.Result);
                    items.Where(it=>it.AlbumId == id).ToList().ForEach(it => model.Results.Items.Add(it));
                }

            }
            catch (Exception ex)
            {
                //TODO: Log here.
            }
            finally
            {

            }

            return View("_Results", model);
        }

        public ActionResult LoadDetail(int? id)
        {
             AlbumsVM model = new AlbumsVM();
            try
            {
                if (id.HasValue)
                {
                    var response = ServiceHelper.Get(CommentsUrl).Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<List<DetailItem>>(response.Result);
                    items.Where(it => it.PostId == id).ToList().ForEach(it => model.Detail.Items.Add(it));
                }

            }
            catch (Exception ex)
            {
                //TODO: Log here.
            }
            finally
            {

            }

            return View("_Detail", model);
        }
    }
}
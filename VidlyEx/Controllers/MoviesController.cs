using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using VidlyEx.Models;
using VidlyEx.ViewModel;

namespace VidlyEx.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Edit(String name)
        //{
        //    return Content(name);
        //}
        public int Index(int n)
        {
            return n;
        }

        ///movies/release/2015/4
        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public (int, string, int) ByReleaseDate(int year,int month)
        {
            return (year, "/", month);
        }

        public Movies Movie = new Movies() {Name = "Lion King"};
        
        public ActionResult Random()
        {
            var customer = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie=Movie,
                Customers = customer
            };

            return View(viewModel);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format(("page Index={0}&sortBy={1}", pageIndex, sortBy).ToString()));
        //}
        
    }
}
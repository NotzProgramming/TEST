using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        /*public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customer = customers
            };


            return View(viewModel);
        }*/

        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }*/


        // to movies
        public ActionResult Index()
        {
            var movieList = new List<Movie>
            {
                new Movie { Name = "Shrek!", Id = 1},
                new Movie { Name = "Wall-e", Id = 2}
                
            };

            var viewModel = new MoviesViewModel()
            {
                movie = movieList
            };

            return View(viewModel);
        }

        /*[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}
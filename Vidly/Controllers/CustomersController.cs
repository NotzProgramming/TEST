using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2},
                new Customer { Name = "Notz", Id = 3}
                
            };

            var viewModel = new CustomerViewModel()
            {
                Customer = customers
            };

            return View(viewModel);
        }

        //[Route("Customers/Detail/{id:range(1,3)}")]
        public ActionResult Detail(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2},
                new Customer { Name = "Notz", Id = 3}

            };

            var viewModel = new CustomerViewModel()
            {
                Customer = customers
            };

            var check = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (check == null)
            {
                return HttpNotFound();
            }


            return View(viewModel);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams"},
                new Customer { Id = 3, Name = "Notz"}
            };
        }
    }
}
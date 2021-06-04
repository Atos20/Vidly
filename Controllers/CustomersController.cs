using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Controllers;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {
            var customers = GetCustomers();
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.Id == id);//lambda expression is an anonymus functio.
                                                                                 //to create one expression you  define the parameter in this case cust on the left side of the operator [=>] and on the right side od the operator and an expression or statemment block on the other side

            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
            //Ienummerables is an interface that defines one method, GetEnumerator which returns Ienumerator interface. This allows read only  access to a collection then that implements IEnumerbale can be used with a for -each statement
        {
            return new List<Customer>
            {
                new Customer { Id=1, Name="Orlando Murcio"},
                new Customer { Id=2, Name="Fabiola Murcio"}
            };
        }
    }
}
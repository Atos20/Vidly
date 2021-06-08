using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Controllers;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private MyDBContext _context;

        public CustomersController()//constructor
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]//attribute to make sure can only be called with httpPost and not httpGet, best practice if you are modifying data
        public ActionResult Save (Customer customer)//we add the model and MVC framewrok will automatically request data to this objecto this
        {
            if(customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                ///TryUpdateModel(customerInDb, "", new string[] { "Name", "Email"}); //with this it  updates the data by key value pairs => Only user with special privileges should update =>, the third parameter whitelists the properties that will be updated but the use of the magic strigs is not sustainable long run 
                
                //With automapper => Mapper.Map(customer, customerInDb)
                customer.Name = customer.Name;
                customerInDb.Name = customer.Birthdate.ToString();
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ViewResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(cust => cust.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);

        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }



    }
}
using Business_Layer.Concrate;
using Business_Layer.FluentValidation;
using DataAccess_Layer.EntityFramework;
using Entity_Layer.Concrate;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI_Layer.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        JoopManager joopManager = new JoopManager(new EfJoopDal());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJoop();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            
            List<SelectListItem> Values = (from x in joopManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text = x.JoobName,
                                              Value = x.JoobId.ToString()
                                          }).ToList();
            ViewBag.v=Values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult results = validationRules.Validate(customer);
            if (results.IsValid)
            {
                customerManager.TInsert(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.GetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> Values = (from x in joopManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.JoobName,
                                               Value = x.JoobId.ToString()
                                           }).ToList();
            ViewBag.v = Values;

            var value = customerManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}

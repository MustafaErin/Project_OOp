using Business_Layer.Concrate;
using Business_Layer.FluentValidation;
using DataAccess_Layer.EntityFramework;
using Entity_Layer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace UI_Layer.Controllers
{
    public class ProductController1 : Controller
    {
        ProductManager productManager=new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator validationRules= new ProductValidator();
            ValidationResult results = validationRules.Validate(product);
            if (results.IsValid)
            {
                productManager.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult DeleteProduct(int id)
        {
            var value=productManager.GetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateProduct(int id)
        {
            var value=productManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}

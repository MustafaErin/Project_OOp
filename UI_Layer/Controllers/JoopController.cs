using Business_Layer.Concrate;
using Business_Layer.FluentValidation;
using DataAccess_Layer.EntityFramework;
using Entity_Layer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace UI_Layer.Controllers
{
    public class JoopController : Controller
    {
        JoopManager joopManager = new JoopManager(new EfJoopDal());
        public IActionResult Index()
        {
            var values = joopManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJoop()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJoop(Joop joop)
        {
            joopManager.TInsert(joop);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJoop(int id)
        {
            var value = joopManager.GetById(id);
            joopManager.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateJoop(int id)
        {
            var value = joopManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJoop(Joop joop)
        {
            joopManager.TUpdate(joop);
            return RedirectToAction("Index");
        }
    }
}

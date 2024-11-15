using Entity_Layer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {   
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel Model)
        {
            AppUser appUser = new AppUser()
            {
                Name = Model.Name,
                Surname = Model.SurName,
                UserName = Model.UserName,
                Email = Model.Mail
            };
            if (Model.password==Model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, Model.password);
                if (result.Succeeded) 
                {
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }

            }
           
            return View(Model);
        }
    }
}

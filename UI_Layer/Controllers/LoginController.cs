using Entity_Layer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signManager;

        public LoginController(SignInManager<AppUser> signManager)
        {
            _signManager = signManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Index(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(model.Username,model.Password,false,true);
                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "ProductController1");
                }
                else
                {
                    ModelState.AddModelError("","Hatalı Kullanıcı Adı ya da Şifre");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
    }
}

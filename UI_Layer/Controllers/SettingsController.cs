using Entity_Layer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UsersEditViewModel usersEditViewModel=new UsersEditViewModel();
            usersEditViewModel.Name = values.Name;
            usersEditViewModel.SurName = values.Surname;
            usersEditViewModel.Mail = values.Email;

            return View(usersEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UsersEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name= model.Name;
            user.Surname = model.SurName;
            user.Email = model.Mail;
            //user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,model.password);
            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded) 
            {
                return RedirectToAction("index","Product");
            }
            else
            {
                // Hata Mesajı
            }


            return View();
        }
    }
}

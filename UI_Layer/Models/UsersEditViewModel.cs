using System.ComponentModel.DataAnnotations;

namespace UI_Layer.Models
{
    public class UsersEditViewModel
    {

        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadı boş geçilemez")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Mail boş geçilemez")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş geçilemez")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrenin eşleştiğinden emin olunuz")]
        public string ConfirmPassword { get; set; }
    }
}

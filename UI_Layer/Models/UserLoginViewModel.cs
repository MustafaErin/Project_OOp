using System.ComponentModel.DataAnnotations;

namespace UI_Layer.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur")]
        public string   Username { get; set; }

        [Required(ErrorMessage = "Parola Zorunludur")]
        public String  Password { get; set; }
    }
}

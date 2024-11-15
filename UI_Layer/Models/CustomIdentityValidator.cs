using Microsoft.AspNetCore.Identity;

namespace UI_Layer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "Password Too Short",
                Description = "Şifre En Az 6 Karakter olmalı, 1büyük,1küçük bir de özel Karakter içermelidir"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Şifre En Az 6 Karakter olmalı, 1büyük,1küçük bir de özel Karakter içermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Şifre En Az 6 Karakter olmalı, 1büyük,1küçük bir de özel Karakter içermelidir"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Şifre En Az 6 Karakter olmalı, 1büyük,1küçük bir de özel Karakter içermelidir"
            };
        }
    }
}

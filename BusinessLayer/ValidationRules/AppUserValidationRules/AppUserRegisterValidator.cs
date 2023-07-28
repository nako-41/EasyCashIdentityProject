using DtoLayer.Dtos.AppUserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı bos gecilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı bos gecilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanici alanı bos gecilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı bos gecilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre alanı bos gecilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Sifre tekrar alanı bos gecilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("lutfen en fazla 30 karakter girisi yapiniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("lutfen en az 3 karakter girisi yapiniz");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("parolaniz eslesmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("lutfen gecerli bir mail adresi giriniz");
        }
    }
}

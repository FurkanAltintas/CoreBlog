using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez")
                .MinimumLength(8).WithMessage("Şifreniz en az 8 karakter olmalıdır")
                .MaximumLength(16).WithMessage("Şifreniz en fazla 16 karakter olmalıdır")
                .Matches(@"[A-Z]+").WithMessage("Şifrenizde en az 1 büyük harf olmalıdır")
                .Matches(@"[a-z]+").WithMessage("Şifrenizde en az 1 küçük harf olmalıdır")
                .Matches(@"[0-9]+").WithMessage("Şifrenizde en az bir rakam olmalıdır");
            //1 büyük 1 küçük ve 1 tane sayı olmak zorunda
            RuleFor(x => x.FullName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.FullName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girşi yapın");
        }
    }
}

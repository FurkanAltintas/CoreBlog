using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz")
                                 .Length(4,150).WithMessage("Blog başlığı 4 ile 150 karakter arasında olmalıdır");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Adını boş geçemezsiniz");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");

        }
    }
}

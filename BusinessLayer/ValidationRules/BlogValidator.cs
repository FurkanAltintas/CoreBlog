using static BusinessLayer.Utilities.ValidatorMessages;
using BusinessLayer.Utilities;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        ValidatorMessages _validatorMessages = new ValidatorMessages();
        Matches matches = new Matches();
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog Başlığı" + _validatorMessages.NotEmpty)
                               .MaximumLength(50).WithMessage("Blog Başlığı {MaxLenght}" + _validatorMessages.MaximumLenght)
                               .MinimumLength(2).WithMessage("Blog Başlığı {MinLenght}" + _validatorMessages.MinimumLenght);

            RuleFor(x => x.Description).NotEmpty().WithMessage("Blog İçeriği " + _validatorMessages.NotEmpty);

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Adı " + _validatorMessages.NotEmpty);

            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog görseli " + _validatorMessages.NotEmpty);

        }
    }
}

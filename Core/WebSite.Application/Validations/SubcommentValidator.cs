using FluentValidation;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Validations
{
    public class SubcommentValidator : AbstractValidator<RequestSubcomment>
    {
        public SubcommentValidator()
        {
            RuleFor(c => c.TheComment)
               .NotEmpty()
               .NotNull()
               .WithMessage("Comment Can Not Empty")
               .MaximumLength(250)
               .WithMessage("Comment Can Be Maximum 200 Characters");

        }
    }
}

using FluentValidation;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Validations
{
    public class ChannelValidator : AbstractValidator<RequestChannel>
    {
        public ChannelValidator()
        {
            RuleFor(c=>c.ChannelDescription)
                .MaximumLength(70)
                .WithMessage("Channel Description Can Be Maximum 70 Characters");

            RuleFor(c=>c.ChannelName)
                .NotEmpty()
                .WithMessage("Category Name Can Not Empty")
                .NotNull()
                .WithMessage("Category Name Can Not Empty")
                .MaximumLength(30)
                .WithMessage("Category Name Can Be Maximum 30 Characters")
                .MinimumLength(2)
                .WithMessage("Category Name Can Be Minimum 2 Characters");
        }
    }
}

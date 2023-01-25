using FluentValidation;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Validations
{
    public class CategoryValidator : AbstractValidator<VMCategory>
    { 
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Category Name Can Not Empty")
                .MaximumLength(50)
                .WithMessage("Category Name Can Be Maximum 70 Characters")
                .MinimumLength(5)
                .WithMessage("Category Name Can Be Minimum 5 Characters");

            RuleFor(c => c.CategoryDescription)
                .NotEmpty()
                .NotNull()
                .WithMessage("Category Name Can Not Empty")
                .MaximumLength(70)
                .WithMessage("Category Description Can Be Maximum 70 Characters")
                .MinimumLength(5)
                .WithMessage("Category Description Can Be Minimum 5 Characters");

        }

    }
}

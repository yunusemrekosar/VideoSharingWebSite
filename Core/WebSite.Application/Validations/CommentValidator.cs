using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.ViewModels;
using WebSite.Domain.Entities;

namespace WebSite.Application.Validations
{
    public class CommentValidator : AbstractValidator<RequestComment>
    {
        public CommentValidator()
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

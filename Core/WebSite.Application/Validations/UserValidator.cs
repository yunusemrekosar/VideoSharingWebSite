using FluentValidation;
using FluentValidation.AspNetCore;
using WebSite.Application.Featurs.Commands.CreateUser;

namespace WebSite.Application.Validations
{
    public class UserValidator : AbstractValidator<CreateUserCommandRequest>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName)
                .NotEmpty()
                .WithMessage("User Name Can Not Empty")
                .NotNull()
                .WithMessage("User Name Can Not Empty")
                .MaximumLength(50)
                .WithMessage("User Name Can Be Maximum 50 Characters")
                .MinimumLength(4)
                .WithMessage("User Name Can Be Minimum 4 Characters");

            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage("Password Can Not Empty")
                .NotNull()
                .WithMessage("Password Can Not Empty")
                .MaximumLength(30)
                .WithMessage("Password Can Be Maximum 30 Characters")
                .MinimumLength(6)
                .WithMessage("Password Can Be Minimum 6 Characters");

            RuleFor(u => u.FirstName)
                .NotEmpty()
                .WithMessage("First Name Can Not Empty")
                .NotNull()
                .WithMessage("First Name Can Not Empty")
                .MaximumLength(50)
                .WithMessage("First Name Can Be Maximum 50 Characters")
                .MinimumLength(2)
                .WithMessage("Firs Name Can Be Minimum 2 Characters");

            RuleFor(u => u.LastName)
                .NotEmpty()
                .WithMessage("Last Name Can Not Empty")
                .NotNull()
                .WithMessage("Last Name Can Not Empty")
                .MaximumLength(50)
                .WithMessage("Last Name Can Be Maximum 50 Characters")
                .MinimumLength(2)
                .WithMessage("Last Name Can Be Minimum 2 Characters");

            RuleFor(u => u.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .WithMessage("Birth Day Can Not Empty");

            RuleFor(u => u.PhoneNumber)
                .NotEmpty()
                .WithMessage("Birth Day Can Not Empty")
                .NotNull()
                .WithMessage("Birth Day Can Not Empty")
                .Length(11)
                .WithMessage("Phone Number Should Be 11 Characters");

            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("Email Address Can Not Empty")
                .NotNull()
                .WithMessage("Email Address Can Not Empty")
                .EmailAddress()
                .WithMessage("Please Enter a Valid Email Address");
                
            RuleFor(u => u.Country)
                .NotEmpty()
                .WithMessage("Country Can Not Empty")
                .NotNull()
                .WithMessage("Country Can Not Empty");

            RuleFor(u=>u.City)
                .NotEmpty()
                .WithMessage("City Can Not Empty")
                .NotNull()
                .WithMessage("City Can Not Empty");

            RuleFor(u=>u.Address)
                .NotEmpty()
                .WithMessage("Address Can Not Empty")
                .NotNull()
                .WithMessage("Address Can Not Empty");




        }
    }
}

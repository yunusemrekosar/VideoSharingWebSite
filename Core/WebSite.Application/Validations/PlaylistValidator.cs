using FluentValidation;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Validations
{
    public class PlaylistValidator : AbstractValidator<VMPlaylist>
    {
        public PlaylistValidator()
        {
            RuleFor(p=>p.PlaylistName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Playlist Name Can Not Empty")
                .MaximumLength(50)
                .WithMessage("Playlist Name Can Be Maximum 50 Characters")
                .MinimumLength(3)
                .WithMessage("Playlist Name Can Be Minimum 3 Characters");

            RuleFor(p=>p.PlaylistDescription)
                .NotEmpty()
                .NotNull()
                .WithMessage("Playlist Description Can Not Empty")
                .MaximumLength(30)
                .WithMessage("Playlist Description Can Be Maximum 30 Characters")
                .MinimumLength(3)
                .WithMessage("Playlist Description Can Be Minimum 3 Characters");

        }
    }
}

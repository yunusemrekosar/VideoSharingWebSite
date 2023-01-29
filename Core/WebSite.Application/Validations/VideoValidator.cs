﻿using FluentValidation;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Validations
{
    public class VideoValidator : AbstractValidator<VMVideo>
    {
        public VideoValidator()
        {
            RuleFor(v=>v.VideoName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Video Name Can Not Empty")
                .MaximumLength(80)
                .WithMessage("Video Name Can Be Maximum 50 Characters")
                .MinimumLength(5)
                .WithMessage("Video Name Can Be Minimum 2 Characters");

            RuleFor(v=>v.VideoDescription)
                .NotEmpty()
                .NotNull()
                .WithMessage("Video Description Can Not Empty")
                .MaximumLength(100)
                .WithMessage("Video Description Can Be Maximum 50 Characters")
                .MinimumLength(5)
                .WithMessage("Video Description Can Be Minimum 2 Characters");
        }
    }
}
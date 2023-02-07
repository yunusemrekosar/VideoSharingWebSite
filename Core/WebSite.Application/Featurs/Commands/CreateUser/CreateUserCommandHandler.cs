using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebSite.Application.Exeptions;
using WebSite.Application.ITablesRepositories.IUserRepository;

namespace WebSite.Application.Featurs.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserWrite _UserWrite;
        readonly IUserRead _userRead;

        public CreateUserCommandHandler(IUserWrite userWrite, IUserRead userRead)
        {
            _UserWrite = userWrite;
            _userRead = userRead;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var useremail = await _userRead.GetSingleAsync(u => u.Email == request.Email);
            if (useremail is not null)
            {
                throw new CostomException("Email Already Using");
            }

            var username = await _userRead.GetSingleAsync(u => u.UserName == request.UserName);

            if (username is not null)
            {
               throw new CostomException("User Name Already Taken");
            }

            await _UserWrite.AddAsync(new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                Country = request.Country,
                City = request.City,
                UserName = request.UserName,
                DateOfBirth = request.DateOfBirth,
                MemberIsWomen = request.MemberIsWomen,
                ProfilePhoto = request.ProfilePhoto,
                IsActive = request.IsActive
            });
            await _UserWrite.SaveAsync();
            return new();
        }
    }
}

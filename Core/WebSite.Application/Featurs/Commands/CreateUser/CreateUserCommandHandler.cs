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
            bool a = false;
            Dictionary<string, string[]> error = new();
            CreateUserCommandResponse response = new();
            var useremail = await _userRead.GetSingleAsync(u => u.Email == request.Email);
            if (useremail is not null)
            {   
                error.Add("Email", new string[] { "Email Already Using" } );
                a = true;
            }

            var username = await _userRead.GetSingleAsync(u => u.UserName == request.UserName);
            if (username is not null)
            {
                error.Add("User Name", new string[] { "User Name Already Taken" } );
                a = true;
            }
            if (a)
            response.Error = error.ToArray();


            if (response.Error is null)
            {
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
            }
            return response;

        }
    }
}

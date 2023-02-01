using MediatR;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Application.ViewModels;

namespace WebSite.Application.Featurs.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<RequestUser, CreateUserCommandResponse>
    {
        readonly IUserWrite _UserWrite;

        public CreateUserCommandHandler(IUserWrite userWrite)
        {

            _UserWrite = userWrite;
        }

        public async Task<CreateUserCommandResponse> Handle(RequestUser request, CancellationToken cancellationToken)
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
            return new();
        }
    }
}

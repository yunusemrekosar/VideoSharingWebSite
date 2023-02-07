using MediatR;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Domain.Entities;

namespace WebSite.Application.Featurs.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        readonly IUserWrite _userWrite;
        readonly IUserRead _userRead;

        public UpdateUserCommandHandler(IUserWrite userWrite, IUserRead userRead)
        {
            _userWrite = userWrite;
            _userRead = userRead;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userRead.GetByIdAsync(request.Id);
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.PhoneNumber = request.PhoneNumber;
            user.Address = request.Address;
            user.Country = request.Country;
            user.City = request.City;
            user.UserName = request.UserName;
            user.DateOfBirth = request.DateOfBirth;
            user.MemberIsWomen = request.MemberIsWomen;
            user.ProfilePhoto = request.ProfilePhoto;
            await _userWrite.SaveAsync();
            return new();
        }
    }
}

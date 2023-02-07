using MediatR;
using WebSite.Application.Featurs.Commands.UpdateUser;
using WebSite.Application.RequestModels;

namespace WebSite.Application.Featurs.Commands.CreateUser
{
    public class CreateUserCommandRequest : RequestUser, IRequest<CreateUserCommandResponse>
    {
       
    }
}

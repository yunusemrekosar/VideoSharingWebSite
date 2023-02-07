using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Featurs.Commands.CreateUser;
using WebSite.Application.RequestModels;

namespace WebSite.Application.Featurs.Commands.UpdateUser
{
    public class UpdateUserCommandRequest : RequestUser, IRequest<UpdateUserCommandResponse>
    {
       

    }
}

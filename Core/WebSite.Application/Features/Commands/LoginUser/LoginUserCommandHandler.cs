using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.TokenAbs;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Application.RequestModels;

namespace WebSite.Application.Featurs.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IUserRead _UserRead;
        readonly ITokenHandler _tokenHandler;

        public LoginUserCommandHandler(IUserWrite userWrite, IUserRead userRead, ITokenHandler token, ITokenHandler tokenHandler)
        {
            _UserRead = userRead;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            LoginUserCommandResponse response = new();

            var user = await _UserRead.GetSingleAsync(e => e.UserName == request.UsernameOrEmail);
            if (user is null)
                user = await _UserRead.GetSingleAsync(e => e.Email == request.UsernameOrEmail);
            var pass = await _UserRead.GetSingleAsync(e => e.Password == request.Password);

            if (user is null || pass is null)
            {
                response.Message = "User Can Not Authenticated";
                return response;
            }
            else

               response.Token = _tokenHandler.CreateToken(7);
               response.Success = true;

            return response;
        }
    }
} 

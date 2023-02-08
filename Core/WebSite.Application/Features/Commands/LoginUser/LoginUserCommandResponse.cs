using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.RequestModels;

namespace WebSite.Application.Featurs.Commands.LoginUser
{
    public class LoginUserCommandResponse
    {
        public Token Token { get; set; }

        public string? Message { get; set; }

        public bool Success{ get; set; }

    }
}

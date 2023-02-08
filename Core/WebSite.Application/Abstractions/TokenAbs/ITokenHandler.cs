using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.RequestModels;

namespace WebSite.Application.Abstractions.TokenAbs
{
    public interface ITokenHandler
    {
         Token CreateToken(int hour);
    }
}

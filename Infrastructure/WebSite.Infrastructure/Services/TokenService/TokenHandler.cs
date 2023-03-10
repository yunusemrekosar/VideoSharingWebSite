using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.TokenAbs;
using WebSite.Application.RequestModels;

namespace WebSite.Infrastructure.Services.TokenService
{

    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;

        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Token CreateToken(int hour)
        {
            Token token = new();
            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(_configuration["Token:SigningKey"]));
            SigningCredentials signingCredentials = new(key, SecurityAlgorithms.HmacSha256);
            token.Expiration = DateTime.UtcNow.AddHours(hour);

            JwtSecurityToken securityToken = new(
                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: token.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials
                );

            JwtSecurityTokenHandler jwtSecurity = new();
            token.AccessToken = jwtSecurity.WriteToken(securityToken);
            return token;
        }
    }
}

using Garanti.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        public string GenerateToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("loremipsumloremipsumloremipsumloremipsum"));

            //token sifreleme algoritmasi
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Email, email)
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = signingCredentials,
                Issuer = "Jwt:Garanti",
                Audience = "Jwt:Garanti"

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenData = tokenHandler.WriteToken(token);

            return tokenData;
        }
    }
}

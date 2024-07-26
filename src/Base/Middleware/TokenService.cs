using ecommerceApi.Model;
using ecommerceApi.Model.Response;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ecommerceApi.src.Base.Middleware;

public class TokenService
{
    public static AuthResponse GeraToken(Usuario user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sid,user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email,user.Email!),
            new Claim("Nome", user.Name!),
        };
        var dataExpires = DateTime.UtcNow.AddDays(1);
        var expiresInSec = dataExpires - DateTime.UtcNow;
        SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(AppSettings.Jwtkey!));
        SigningCredentials signIn = new(key, SecurityAlgorithms.HmacSha256);
        JwtSecurityToken securityToken = new(AppSettings.JwtIssuer, AppSettings.JwtAudience,
                                             claims,
                                             expires: dataExpires,
                                             signingCredentials: signIn);
        var response = new AuthResponse()
        {
            Access_Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
            Expires = (int)expiresInSec.TotalSeconds,
            Token_Type = "Bearer"
        };

        return response;
    }
}
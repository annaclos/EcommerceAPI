using Microsoft.Extensions.Configuration;
using System.Net.NetworkInformation;

namespace ecommerceApi.src.Base.Middleware;

public static class AppSettings
{
    #region connection string postgree
    public static string? ConnectionString { get; set; }
    #endregion

    #region jwt
    public static string? Jwtkey { get; set; }
    public static string? JwtIssuer {  get; set; }
    public static string? JwtAudience {  get; set; }
    #endregion

    public static void LoadSettings(IConfiguration config)
    {
        ConnectionString = config.GetValue<string>("ConnectionStrings:postgres");
        Jwtkey = config.GetValue<string>("Jwt:JwtKey");
        JwtIssuer = config.GetValue<string>("Jwt:JwtIssuer");
        JwtAudience = config.GetValue<string>("Jwt:JwtAudience");
    }
}

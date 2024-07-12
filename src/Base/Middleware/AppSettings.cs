using Microsoft.Extensions.Configuration;

namespace ecommerceApi.src.Base.Middleware;

public static class AppSettings
{
    #region connection string postgree
    public static string? ConnectionString { get; set; }
    #endregion
    public static void LoadSettings(IConfiguration config)
    {
        ConnectionString = config.GetValue<string>("ConnectionStrings:postgres");
    }
}

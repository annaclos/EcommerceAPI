namespace ecommerceApi.Model.Response;

public class AuthResponse
{
    public string? Access_Token { get; set; }
    public int Expires { get; set;}
    public string? Token_Type { get; set;}

}

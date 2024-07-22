using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecommerceApi.Model;

public class Usuario : BaseEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Cpf { get; set; }
    public string? Birthday { get; set; }
    public string? PhoneNumber { get; set;}

    [MaxLength(1)]
    public string? Gender { get; set;}

    [DefaultValue(true)]
    public bool Active { get; set; } = true;

    #region relacionamento
    public IEnumerable<Endereco>? Endereco { get; set; }

    #endregion
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ecommerceApi.Model;

public class Endereco : BaseEntity
{
    [Required]
    public string? Address { get; set; }

    [Required]
    public int? Number { get; set; }

    public string? Reference { get; set; }

    [Required]
    public string? District { get; set; }

    [Required]
    public string? City { get; set; }

    [Required]
    [StringLength(2)]
    public string? Uf { get; set; }

    [Required]
    public string? Cep { get; set; }


    #region Relacionamento

    public int UsuarioId { get; set; }
    [XmlIgnore, JsonIgnore]
    public Usuario? Usuario { get; set; }

    #endregion
}

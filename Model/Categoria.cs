using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ecommerceApi.Model;

public class Categoria : BaseEntity
{
    public string? Name { get; set; }

    [XmlIgnore, JsonIgnore]
    public IEnumerable<Produto>? Produtos { get; set; }
}

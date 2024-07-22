namespace ecommerceApi.Model;

public class Categoria : BaseEntity
{
    public string? Name { get; set; }
    public IEnumerable<Produto>? Produtos { get; set; }
}

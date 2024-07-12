using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Repository;

public interface IProdutoRepository
{
    Task<Produto> Create(Produto produto);
    Task<Produto> Get(int id);
    Task<Produto> Update(Produto produto);
    Task<bool> Delete(int id);
    Task<List<Produto>> List();
    Task<bool> DesativaProduto(int id);
}

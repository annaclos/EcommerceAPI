using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Service;

public interface IProdutoService
{
    Task<Produto> Create(Produto produto);
    Task<Produto> Get(int id);
    Task<Produto> Update(Produto produto);
    Task<bool> Delete(int id);
    Task<List<Produto>> List();

}

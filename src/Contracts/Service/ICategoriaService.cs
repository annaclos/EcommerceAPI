using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Service;

public interface ICategoriaService
{
    Task<Categoria> Create(Categoria categoria);
    Task<Categoria> Get(int id);
    Task<Categoria> Update(Categoria categoria);
    Task<bool> Delete(int id);
    Task<List<Categoria>> List();
}

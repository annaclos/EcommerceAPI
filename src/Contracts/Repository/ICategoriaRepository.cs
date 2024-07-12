using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Repository;

public interface ICategoriaRepository
{
    Task<Categoria> Get(int id);
    Task<Categoria> Create(Categoria categoria);
    Task<Categoria> Update(Categoria categoria);
    Task<bool> Delete(int id);
    Task<List<Categoria>> List();
}

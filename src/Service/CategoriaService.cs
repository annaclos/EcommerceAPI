using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;
using ecommerceApi.src.Repository;

namespace ecommerceApi.src.Service;

public class CategoriaService(ICategoriaRepository _repository) : ICategoriaService
{
    public async Task<Categoria> Create(Categoria categoria)
    {
        return await _repository.Create(categoria);
    }

    public async Task<bool> Delete(int id)
    {
        return await _repository.Delete(id);
    }

    public async Task<Categoria> Get(int id)
    {
        return await _repository.Get(id);
    }

    public async Task<List<Categoria>> List()
    {
        return await _repository.List();
    }

    public async Task<Categoria> Update(Categoria categoria)
    {
        return await _repository.Update(categoria);
    }
}

using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;

namespace ecommerceApi.src.Service;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;
    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }
    public async Task<Produto> Create(Produto produto)
    {
        return await _produtoRepository.Create(produto);
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DesativaProduto(int id)
    {
        return _produtoRepository.DesativaProduto(id);
    }

    public Task<Produto> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Produto>> List()
    {
        throw new NotImplementedException();
    }

    public Task<Produto> Update(Produto produto)
    {
        throw new NotImplementedException();
    }

}

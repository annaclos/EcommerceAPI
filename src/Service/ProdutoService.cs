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

    public async Task<bool> Delete(int id)
    {
        return await _produtoRepository.Delete(id);
    }

    public async Task<Produto> Get(int id)
    {
        return await _produtoRepository.Get(id);
    }

    public async Task<List<Produto>> List()
    {
        return await _produtoRepository.List();
    }

    public async Task<Produto> Update(Produto produto)
    {
        return await _produtoRepository.Update(produto);
    }

}

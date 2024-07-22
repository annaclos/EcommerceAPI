using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;
using ecommerceApi.src.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ecommerceApi.src.Service;

public class EnderecoService : IEnderecoService
{
    private readonly IEnderecoRepository _repository;
    public EnderecoService(IEnderecoRepository repository)
    {
        _repository = repository;
    }
    public async Task<Endereco> Create(Endereco endereco)
    {
        return await _repository.Create(endereco);
    }

    public async Task<bool> Delete(int id)
    {
        return await _repository.Delete(id);
    }

    public async Task<Endereco> Get(int id)
    {
        return await _repository.Get(id);
    }

    public async Task<List<Endereco>> List()
    {
        return await _repository.List();
    }

    public async Task<Endereco> Update(Endereco endereco)
    {
        return await _repository.Update(endereco);
    }
}

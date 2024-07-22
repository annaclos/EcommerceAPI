using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Service;

public interface IEnderecoService
{
    Task<Endereco> Create(Endereco endereco);
    Task<Endereco> Update(Endereco endereco);
    Task<bool> Delete(int id);
    Task<Endereco> Get(int id);
    Task<List<Endereco>> List();
}

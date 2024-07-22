using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Repository;

public interface IEnderecoRepository
{
    Task<Endereco> Create(Endereco endereco);
    Task<Endereco> Update(Endereco endereco);
    Task<bool> Delete(int id);
    Task<Endereco> Get(int id);
    Task<List<Endereco>> List();
}

using ecommerceApi.Model;

namespace ecommerceApi.src.Contracts.Service;

public interface IUsuarioService
{
    Task<Usuario> Create(Usuario usuario);
    Task<Usuario> Get(int id);
    Task<Usuario> Update(Usuario usuario);
    Task<bool> Delete(int id);
    Task<List<Usuario>> List();
}

using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;

namespace ecommerceApi.src.Service;

public class UsuarioService(IUsuarioRepository _usuarioRepository) : IUsuarioService
{
    public async Task<Usuario> Create(Usuario usuario)
    {
        return await _usuarioRepository.Create(usuario);
    }

    public async Task<bool> Delete(int id)
    {
        return await _usuarioRepository.Delete(id);
    }

    public async Task<Usuario> Get(int id)
    {
        return await _usuarioRepository.Get(id);
    }

    public async Task<List<Usuario>> List()
    {
        return await _usuarioRepository.List();
    }

    public async Task<Usuario> Update(Usuario usuario)
    {
        return await _usuarioRepository.Update(usuario);
    }
}

using ecommerceApi.Model;
using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Contracts.Repository;

namespace ecommerceApi.src.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly DataContext _context;
    public UsuarioRepository(DataContext context)
    {
        _context = context;
        
    }
    public async Task<Usuario> Create(Usuario usuario)
    {
        _context.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> List()
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> Update(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}

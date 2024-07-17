using ecommerceApi.Model;
using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

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

    public async Task<bool> Delete(int id)
    {
        var deleteUser = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        if (deleteUser == null)
            throw new Exception("Usuário nao encontrado");

        _context.Remove(deleteUser);
        return await _context.SaveChangesAsync() == 1;
    }

    public async Task<Usuario> Get(int id)
    {
        var usuarioGet = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        if (usuarioGet != null)
        {
            return usuarioGet;
        }
        else
        {
            throw new Exception("Usuário não cadastrado");
        }
    }

    public async Task<List<Usuario>> List()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> Update(Usuario usuario)
    {
        _context.Update(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }
}

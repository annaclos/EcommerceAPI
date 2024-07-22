using ecommerceApi.Model;
using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace ecommerceApi.src.Repository;

public class EnderecoRepository(DataContext _context) : IEnderecoRepository
{
    public async Task<Endereco> Create(Endereco endereco)
    {
        _context.Add(endereco);
        await _context.SaveChangesAsync();
        return endereco;
    }

    public async Task<bool> Delete(int id)
    {
        var deleteEndereco = await _context.Enderecos.FirstOrDefaultAsync(x=>x.Id==id);
        if (deleteEndereco == null)
            throw new Exception("Endereço não encontrado");
        
            _context.Remove(deleteEndereco);
            return await _context.SaveChangesAsync() > 0;  
    }

    public async Task<Endereco> Get(int id)
    {
        var getEndereco = await _context.Enderecos.FirstOrDefaultAsync(x=>x.Id==id);
        if (getEndereco == null)
            throw new Exception("Endereço não encontrado");
        
        return getEndereco;
    }

    public async Task<List<Endereco>> List()
    {
        return await _context.Enderecos.ToListAsync();
    }

    public async Task<Endereco> Update(Endereco endereco)
    {
        _context.Update(endereco);
        await _context.SaveChangesAsync();
        return endereco;
    }
}

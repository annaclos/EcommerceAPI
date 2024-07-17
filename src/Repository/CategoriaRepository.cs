using ecommerceApi.Model;
using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace ecommerceApi.src.Repository
{
    public class CategoriaRepository(DataContext _context) : ICategoriaRepository
    {
        public async Task<Categoria> Create(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteCateg = await _context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (deleteCateg == null)
                throw new Exception("Categoria inexistente");

            _context.Remove(deleteCateg);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<Categoria> Get(int id)
        {
            var getCateg = await _context.Categorias.FirstOrDefaultAsync(x => x.Id == id);
            if (getCateg == null)
                throw new Exception("Categoria nao encontrada");

            return getCateg;
        }

        public async Task<List<Categoria>> List()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> Update(Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }
    }
}

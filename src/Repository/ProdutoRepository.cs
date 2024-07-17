using ecommerceApi.Model;
using ecommerceApi.src.Base.DataBase;
using ecommerceApi.src.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace ecommerceApi.src.Repository
{
    public class ProdutoRepository(DataContext _context) : IProdutoRepository
    {
        public async Task<Produto> Create(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteProd = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            if (deleteProd == null)
                throw new Exception("Produto não encontrado");

            _context.Remove(deleteProd);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Produto> Get(int id)
        {
            var findProd = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            if (findProd == null)
                throw new Exception("Produto não encontrado");

            return findProd;
        }

        public async Task<List<Produto>> List()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> Update(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
            return produto;
        }


    }
}

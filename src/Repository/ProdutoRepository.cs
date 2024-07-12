using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Repository;

namespace ecommerceApi.src.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<Produto> Create(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DesativaProduto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> List()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> Update(Produto produto)
        {
            throw new NotImplementedException();
        }


    }
}

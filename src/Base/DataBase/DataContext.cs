using ecommerceApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ecommerceApi.src.Base.DataBase;

public class DataContext : DbContext
{
    public DataContext()
    {
       
    }
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
}

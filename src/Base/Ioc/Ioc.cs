using ecommerceApi.src.Contracts.Repository;
using ecommerceApi.src.Contracts.Service;
using ecommerceApi.src.Repository;
using ecommerceApi.src.Service;

namespace ecommerceApi.src.Base.Ioc
{
    public class Ioc
    {
        public static void DependenceInjection(IServiceCollection services)
        {
            #region repository

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            #endregion

            #region Service

            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IEnderecoService, EnderecoService>();

            #endregion
        }
    }
}

using Livraria.Application.Apps;
using Livraria.Application.Interfaces;
using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Infra.DI
{
    public class Bootstrap
    {
        public static void Configuracao(IServiceCollection service, string conexao)
        {
            service.AddDbContext<LivrariaContext>(op => op.UseSqlServer(conexao));

            service.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));

            service.AddScoped<IAssunto, AssuntoRepositorio>();
            service.AddScoped<IAssuntoApp, AssuntoApp>();

            service.AddScoped<IAutor, AutorRepositorio>();
            service.AddScoped<IAutorApp, AutorApp>();

            service.AddScoped<IEditora, EditoraRepositorio>();
            service.AddScoped<IEditoraApp, EditoraApp>();

            service.AddScoped<ILivro, LivroRepositorio>();
            service.AddScoped<ILivroApp, LivroApp>();
        }
    }
}

using Livraria.Domain.Domains;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Data.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options):base(options)
        {
        }

        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }        
    }
}

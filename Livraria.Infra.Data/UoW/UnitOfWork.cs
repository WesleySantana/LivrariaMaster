using Livraria.Domain.Interfaces.UoW;
using Livraria.Infra.Data.Context;
using System.Threading.Tasks;

namespace Livraria.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LivrariaContext _context;

        public UnitOfWork(LivrariaContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

using System;
using System.Threading.Tasks;

namespace Livraria.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
    }
}
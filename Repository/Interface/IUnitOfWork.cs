using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        CompanyContext _context { get; }
        IUserRepository UserRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IOrderDetailsRepository OrderDetailsRepository { get; }


        int SaveChanges();
        Task<int> SaveChangesAsync();

    }
}

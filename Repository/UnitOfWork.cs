using Data;
using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;

        public CompanyContext _context { get; }

        public IUserRepository UserRepository { get; }

        public IOrderRepository OrderRepository { get; }

        public IOrderDetailsRepository OrderDetailsRepository { get; }

        public IProductRepository ProductRepository { get; }

        public UnitOfWork(CompanyContext context,IUserRepository userRepository, IOrderRepository orderRepository , IProductRepository productRepository , IOrderDetailsRepository orderDetailsRepository)
        {
            _context = context;
            UserRepository = userRepository;
            OrderRepository = orderRepository;
            ProductRepository = productRepository;
            OrderDetailsRepository = orderDetailsRepository;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public  Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}

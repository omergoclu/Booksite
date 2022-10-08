using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;

namespace booksite.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookContext _context;
        public UnitOfWork(BookContext context)
        {
            _context = context;   
        }
        private EfCoreCartRepository _cartRepository;
        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreOrderRepository _orderRepository;
        private EfCoreBookRepository _bookRepository;
        private EfCoreAuthorRepository _authorRepository;
        private EfCorePublisherRepository _publisherRepository;
        public ICartRepository Carts => 
            _cartRepository = _cartRepository ?? new EfCoreCartRepository(_context);

        public ICategoryRepository Categories =>
            _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public IOrderRepository Orders =>
            _orderRepository = _orderRepository ?? new EfCoreOrderRepository(_context);

        public IBookRepository Books =>
            _bookRepository = _bookRepository ?? new EfCoreBookRepository(_context);

        public IAuthorRepository Authors =>
            _authorRepository = _authorRepository ?? new EfCoreAuthorRepository(_context);

        public IPublisherRepository Publishers =>
            _publisherRepository = _publisherRepository ?? new EfCorePublisherRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
           _context.SaveChanges();
        }
    }
}
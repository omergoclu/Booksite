using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order>, IOrderRepository
    {
        public EfCoreOrderRepository(BookContext context):base(context)
        {
            
        }
        private BookContext BookContext
        {
            get {return context as BookContext;}
        }

        public List<Order> GetByAdminOrders(string userId)
        {
            var orders = BookContext.Orders
                                .Include(i=>i.OrderItems)
                                .ThenInclude(i=>i.Book)
                                .AsQueryable();
            return orders.ToList();
        }

        public List<Order> GetOrders(string userId)
        {
            var orders = BookContext.Orders
                                .Include(i=>i.OrderItems)
                                .ThenInclude(i=>i.Book)
                                .AsQueryable();

            if(!string.IsNullOrEmpty(userId))
            {
                orders = orders.Where(i=>i.UserId==userId);
            }
            return orders.ToList();
        }
    }
}
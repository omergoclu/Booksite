using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
        List<Order> GetByAdminOrders(string userId);
    }
}
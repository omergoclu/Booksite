using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        
        void AddToCart(string userId , int bookId, int quantity);
        void DeleteFromCart(string userId, int bookId);
        void ClearCart(int cartId);
    }
}
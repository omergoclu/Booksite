using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(BookContext context):base(context)
        {
            
        }
        private BookContext BookContext
        {
            get {return context as BookContext;}
        }
        public void ClearCart(int cartId)
        {
            var cmd = @"delete from CartItems where CartId=@p0 ";
            BookContext.Database.ExecuteSqlRaw(cmd,cartId,cartId);
        }

        public void DeleteFromCart(int cartId, int bookId)
        {
            var cmd = @"delete from CartItems where CartId=@p0 and BookId=@p1";
            BookContext.Database.ExecuteSqlRaw(cmd,cartId,bookId);
        }

        public Cart GetByUserId(string userId)
        {
            return BookContext.Carts
                        .Include(i=>i.CartItems)
                        .ThenInclude(i=>i.Book)
                        .FirstOrDefault(i=>i.UserId==userId);
        }

        public override void Update(Cart entity)
        {
            BookContext.Carts.Update(entity);
        }
    }
}
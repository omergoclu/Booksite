using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(BookContext context):base(context)
        {
            
        }
        private BookContext BookContext
        {
        get {return context as BookContext;}
        }
        public void DeleteFromCategory(int bookId, int categoryId)
        {
            var cmd = "delete from bookcategory where BookId=@p0 and CategoryId=@p1";
            BookContext.Database.ExecuteSqlRaw(cmd,bookId,categoryId);
        }

        public Category GetByIdWithBooks(int categoryId)
        {
            return BookContext.Categories
                        .Where(i=>i.CategoryId==categoryId)
                        .Include(i=>i.BookCategories)
                        .ThenInclude(i=>i.Book)
                        .FirstOrDefault();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category GetByIdWithBooks(int categoryId);
        void DeleteFromCategory(int bookId, int categoryId);
    }
}
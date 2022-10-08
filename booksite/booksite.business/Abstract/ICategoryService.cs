using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface ICategoryService:IValidator<Category>
    {
        Category GetById(int id);
        Category GetByIdWithBooks(int categoryId);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void DeleteFromCategory(int bookId, int categoryId);
    }
}
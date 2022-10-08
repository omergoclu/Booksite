using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface IBookService:IValidator<Book>
    {
        Book GetById(int id);
        Book GetByIdWithCategories(int id);
        Book GetByIdWithAuthors(int id);
        Book GetByIdWithPublishers(int id);
        Book GetBookDetails(string url);
        List<Book> GetBookPublishers(int id);
        List<Book> GetBookAuthors(int id);
        List<Book> GetBookByCategory(string name,int page , int pageSize);
        List<Book> GetHomePageBooks(string name,int page , int pageSize);
        List<Book> GetSearchResult(string searchString );
        List<Book> GetAll();
        bool Create(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
        int GetCountByCategory(string category);
        bool Update(Book entity, int[] categoryIds);
    }
}
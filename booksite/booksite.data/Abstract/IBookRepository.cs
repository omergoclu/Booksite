using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.data.Abstract
{
    public interface IBookRepository:IRepository<Book>
    {
        Book GetBookDetails(string url);
        List<Book> GetBookPublishers(int id);
        List<Book> GetBookAuthors(int id);
        Book GetByIdWithCategories(int id);
        Book GetByIdWithAuthors(int id);
        Book GetByIdWithPublishers(int id);
        List<Book> GetBookByCategory(string name,int page , int pageSize);
        List<Book> GetSearchResult(string searchString );
        List<Book> GetTop5Books();
        List<Book> GetHomePageBooks(string name,int page , int pageSize);
        int GetCountByCategory(string category);
        void Update(Book entity, int[] categoryIds);

    }
}
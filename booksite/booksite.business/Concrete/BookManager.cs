using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.data.Abstract;
using booksite.data.Concrete.EfCore;
using booksite.entity;

namespace booksite.business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IUnitOfWork _unitofwork;
        public BookManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public bool Create(Book entity)
        {
            if(Validation(entity))
            {
                _unitofwork.Books.Create(entity);
                _unitofwork.Save();
                return true;
            }
            return false;
        }

        public void Delete(Book entity)
        {
            // iş kuralları
            _unitofwork.Books.Delete(entity);
            _unitofwork.Save();
        }

        public List<Book> GetAll()
        {
            // iş kuralları
            return _unitofwork.Books.GetAll();
        }

        public Book GetBookDetails(string url)
        {
            return _unitofwork.Books.GetBookDetails(url);
        }

        public Book GetById(int id)
        {
            return _unitofwork.Books.GetById(id);
        }

        public Book GetByIdWithAuthors(int id)
        {
            return _unitofwork.Books.GetByIdWithAuthors(id);

        }

        public Book GetByIdWithCategories(int id)
        {
            return _unitofwork.Books.GetByIdWithCategories(id);
        }

        public Book GetByIdWithPublishers(int id)
        {
            return _unitofwork.Books.GetByIdWithPublishers(id);
        }

        public List<Book> GetBookByCategory(string name,int page , int pageSize)
        {
            return _unitofwork.Books.GetBookByCategory(name,page,pageSize);
        }
        public int GetCountByCategory(string category)
        {
            return _unitofwork.Books.GetCountByCategory(category);
        }
        public List<Book> GetHomePageBooks(string name,int page , int pageSize)
        {
            return _unitofwork.Books.GetHomePageBooks(name,page,pageSize);
        }

        public List<Book> GetSearchResult(string searchString)
        {
            return _unitofwork.Books.GetSearchResult(searchString);
        }

        public void Update(Book entity)
        {
            _unitofwork.Books.Update(entity);
            _unitofwork.Save();
        }

        public bool Update(Book entity, int[] categoryIds)
        {
            if(Validation(entity))
            {
                if(categoryIds.Length==0)
                {
                    ErrorMessage +="You must select at least one category for the book";
                    return false;
                }
                _unitofwork.Books.Update(entity,categoryIds); 
                _unitofwork.Save();
                return true;
            }
            return false;
        }

        public string ErrorMessage { get; set; }
        public bool Validation(Book entity)
        {
            var isValid = true;
            if(string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage +="you must enter the name of the book. \n";
                isValid = false;
            }
            if(entity.Price<0)
            {
                ErrorMessage +="The book price cannot be negative. \n";
                isValid = false;
            }
            return isValid;
        }

        List<Book> IBookService.GetBookPublishers(int id)
        {
            return _unitofwork.Books.GetBookPublishers(id);
        }

        public List<Book> GetBookAuthors(int id)
        {
            return _unitofwork.Books.GetBookAuthors(id);

        }
    }
}
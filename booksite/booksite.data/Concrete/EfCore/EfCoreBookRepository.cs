using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCoreBookRepository : EfCoreGenericRepository<Book>, IBookRepository
    {
        public EfCoreBookRepository(BookContext context):base(context)
        {   
        }
        private BookContext BookContext
        {
            get {return context as BookContext;}
        }
        public List<Book> GetBookByCategory(string name,int page , int pageSize)
        {
            var books = BookContext
                .Books
                .Where(i=>i.IsApproved)
                .AsQueryable();

            if(!string.IsNullOrEmpty(name))
            {
                books = books
                            .Include(i=>i.BookCategories)
                            .ThenInclude(i=>i.Category)
                            .Where(i=>i.BookCategories.Any(a=>a.Category.Url==name));           
            }
            return books.Skip((page-1)*pageSize).Take(pageSize).ToList();
        }

        public Book GetBookDetails(string url)
        {
            return BookContext.Books
                            .Where(i=>i.Url==url)
                            .Include(i=>i.BookCategories)
                            .ThenInclude(i=>i.Category)
                            .FirstOrDefault();
        }
        List<Book> IBookRepository.GetBookPublishers(int id)
        {
           var books = BookContext
                .Books
                .Where(i=>i.IsApproved)
                .AsQueryable();

            
                books = books
                            .Where(i=>i.PublisherId==id)
                            .Include(i=>i.Publisher);          
            
            return books.ToList();
        }

        public Book GetByIdWithAuthors(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetByIdWithCategories(int id)
        {
            return BookContext.Books
                            .Where(i=>i.BookId==id)
                            .Include(i=>i.BookCategories)
                            .ThenInclude(i=>i.Category)
                            .FirstOrDefault();
        }

        public Book GetByIdWithPublishers(int id)
        {
            var books = BookContext
                    .Books
                    .Where(i=>i.IsApproved)
                    .ToList();
            
            books = books
                    .Where(h=>h.PublisherId==id).ToList();

            return books.First();
        }

        public int GetCountByCategory(string category)
        {
            var books = BookContext.Books.Where(i=>i.IsApproved).AsQueryable();

            if(!string.IsNullOrEmpty(category))
            {
                books = books
                            .Include(i=>i.BookCategories)
                            .ThenInclude(i=>i.Category)
                            .Where(i=>i.BookCategories.Any(a=>a.Category.Url==category));           
            }
            return books.Count();
        }

        public List<Book> GetHomePageBooks(string name,int page , int pageSize)
        {
            var books = BookContext
                .Books
                .Where(i=>i.IsApproved)
                .AsQueryable();

            if(!string.IsNullOrEmpty(name))
            {
                books = books
                            .Include(i=>i.BookCategories)
                            .ThenInclude(i=>i.Category)
                            .Where(i=>i.BookCategories.Any(a=>a.Category.Url==name))
                            ;
            }
            return books.Skip((page-1)*pageSize).Take(pageSize).Where(i=>i.IsHome).ToList();
        }

        public List<Book> GetSearchResult(string searchString)
        {
            var books = BookContext
                .Books
                .Where(i=>i.IsApproved && (i.Name.ToLower().Contains(searchString)) || (i.Description.ToLower().Contains(searchString)))
                .AsQueryable();
            return books.ToList();
        }

        public List<Book> GetTop5Books()
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity, int[] categoryIds)
        {
            var book = BookContext.Books
                        .Include(i=>i.BookCategories)
                        .FirstOrDefault(i=>i.BookId==entity.BookId);
            
            if(book!=null)
            {
                book.Name = entity.Name;
                book.Url = entity.Url;
                book.Price = entity.Price;
                book.Description = entity.Description;
                book.ImageUrl = entity.ImageUrl;
                book.BarcodeNumber = entity.BarcodeNumber;
                book.PageCount = entity.PageCount;
                book.FirstPrintDate = entity.FirstPrintDate;
                book.AuthorId = entity.AuthorId;
                book.PublisherId = entity.PublisherId;
                book.IsApproved = entity.IsApproved;
                book.IsHome = entity.IsHome;

                book.BookCategories = categoryIds.Select(catid=> new BookCategory(){
                    BookId=entity.BookId,
                    CategoryId=catid
                }).ToList();
            }
        }

        public List<Book> GetBookAuthors(int id)
        {
            var books = BookContext
                .Books
                .Where(i=>i.IsApproved)
                .AsQueryable();

            
                books = books
                            .Where(i=>i.AuthorId==id)
                            .Include(i=>i.Author);          
            
            return books.ToList();
        }
    }
}
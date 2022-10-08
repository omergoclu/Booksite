using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.entity;
using booksite.webui.Extensions;
using booksite.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace booksite.webui.Controllers
{
    public class ShopController:Controller
    {
        private IBookService _bookService;
        private IAuthorService _authorService;
        private IPublisherService _publisherService;

        public ShopController(IBookService bookService,IAuthorService authorService,
        IPublisherService publisherService)
        {
            this._bookService= bookService;
            this._authorService= authorService;
            this._publisherService= publisherService;
        }
        public IActionResult List(int id,string category,int page=1)
        {
            const int pageSize=5;
            var bookViewModel = new BookListViewModel()
            {
                Publishers = _publisherService.GetAll(),
                Authors = _authorService.GetAll(),
                PageInfo = new PageInfo(){
                    TotalItems = _bookService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemPerPage = pageSize,
                    CurrentCategory = category
                },
                Books = _bookService.GetBookByCategory(category,page,pageSize),
            };

            return View(bookViewModel);
        }
        
        public IActionResult PublisherList(int id)
        {
            var bookViewModel = new BookListViewModel()
            {
                Publishers = _publisherService.GetAll(),
                Authors = _authorService.GetAll(),
                Books = _bookService.GetBookPublishers(id),
            };
            return View(bookViewModel); 
        }
        
        public IActionResult AuthorList(int id)
        {
            var bookViewModel = new BookListViewModel()
            {
                Authors = _authorService.GetAll(),
                Publishers = _publisherService.GetAll(),
                Books = _bookService.GetBookAuthors(id),
            };
            return View(bookViewModel); 
        }

        public IActionResult Details(string url)
        {
            if(url==null)
            {
                return NotFound();
            }
            Book book = _bookService.GetBookDetails(url);
            if(book==null)
            {
                return NotFound();
            }
            return View(new BookDetailModel{
                Publishers = _publisherService.GetAll(),
                Authors = _authorService.GetAll(),
                Book = book,
                Categories = book.BookCategories.Select(i=>i.Category).ToList(),
            });
            
        }

        public IActionResult Search(string q)
        {
            var bookViewModel = new BookListViewModel()
            {
                Publishers = _publisherService.GetAll(),
                Authors = _authorService.GetAll(),
                Books = _bookService.GetSearchResult(q)
            };
            if(q==null)
            {
                TempData.Put("message",new AlertMessage(){
                Title="There are no results.",
                Message = $" You made an empty search.",
                AlertType = "warning"
                });
            }
            
            return View(bookViewModel);
        }
    }
}
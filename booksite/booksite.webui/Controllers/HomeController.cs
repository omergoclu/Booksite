using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using booksite.webui.Models;
using booksite.data.Abstract;
using booksite.business.Abstract;

namespace booksite.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {   
        private IBookService _bookService;
        private IPublisherService _publisherService;
        private IAuthorService _authorService;

        public HomeController(IBookService bookService,IPublisherService publisherService,IAuthorService authorService)
        {
            this._bookService= bookService;
            this._publisherService = publisherService;
            this._authorService = authorService;
        }
        public IActionResult Index(int id,string category,int page=1)
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
                Books = _bookService.GetHomePageBooks(category,page,pageSize),
            };
            _bookService.GetBookPublishers(id);
            _bookService.GetBookAuthors(id);
            return View(bookViewModel);
        }
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View();
        }
    }
}
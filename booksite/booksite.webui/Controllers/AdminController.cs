using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.entity;
using booksite.webui.Extensions;
using booksite.webui.Identity;
using booksite.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace booksite.webui.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController:Controller
    {
        private IBookService _bookService;
        private IAuthorService _authorService;
        private IPublisherService _publisherService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        public AdminController(IBookService bookService,
        IAuthorService authorService,
        ICategoryService categoryService,
        IPublisherService publisherService,
        RoleManager<IdentityRole> roleManager,
        UserManager<User> userManager)
        {
            _bookService = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user =  await _userManager.FindByIdAsync(id);
            if(user!=null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i=>i.Name);

                ViewBag.Roles = roles;
                return View(new UserDetailsModel(){
                    UserId = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                    
                });
            }
            return Redirect("~/admin/user/list");
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model,string[] selectedRoles)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if(user!=null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if(result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles?? new string[]{};
                        await _userManager.AddToRolesAsync(user,selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/user/list");
                    }
                }
                return Redirect("/admin/user/list");
            }
            return View(model);
        }

        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user!=null)
            {
                var result = await _userManager.DeleteAsync(user);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The user has been deleted.",
            Message = $"The user has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("UserList");
        }
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user,role.Name)
                                ?members:nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if(ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {
                        var result = await _userManager.AddToRoleAsync(user,model.RoleName);
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
          
                foreach (var userId in model.IdsToDelete ?? new string[]{})
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if(user!=null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user,model.RoleName);
                        if(!result.Succeeded)
                        {
                              foreach (var error in result.Errors)
                              { 
                                ModelState.AddModelError("", error.Description);  
                              }  
                        }
                    }
                }
            }
            return Redirect("/admin/role/"+model.RoleId);
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if(result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else{
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("",error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if(role!=null)
            {
                var result = await _roleManager.DeleteAsync(role);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The role has been deleted.",
            Message = $"The role has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("RoleList");
        }
        public IActionResult BookList()
        {
            return View(new BookListViewModel{
                Books = _bookService.GetAll(),
                Authors = _authorService.GetAll(),
                Publishers = _publisherService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult BookCreate()
        {
            ViewBag.Authors = new SelectList(_authorService.GetAll(),"AuthorId","NameLastName");
            ViewBag.Publishers = new SelectList(_publisherService.GetAll(),"PublisherId","Name");
            return View();
        }
        [HttpPost]
        public IActionResult BookCreate(BookModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = new Book()
                {
                    Name = model.Name,
                    Url = model.Url,
                    Price = model.Price,
                    Description = model.Description,
                    ImageUrl = model.ImageUrl,
                    BarcodeNumber = model.BarcodeNumber,
                    PageCount = model.PageCount,
                    FirstPrintDate = model.FirstPrintDate,
                    AuthorId = model.AuthorId,
                    PublisherId = model.PublisherId,
                };
                if(_bookService.Create(entity))
                {
                    TempData.Put("message",new AlertMessage(){
                    Title="The book has been added.",
                    Message = $"{entity.Name} The book has been successfully added.",
                    AlertType = "success"
                    });
                    return RedirectToAction("BookList");
                }
                return View(model);
            }
            return View(model);
            
        }
        [HttpGet]
        public IActionResult BookEdit(int? id)
        {
            ViewBag.Authors = new SelectList(_authorService.GetAll(),"AuthorId","NameLastName");
            ViewBag.Publishers = new SelectList(_publisherService.GetAll(),"PublisherId","Name");
            if(id==null)
            {
                return NotFound();
            }
            var entity = _bookService.GetByIdWithCategories((int)id);
            if(entity==null)
            {
                return NotFound();

            }
            var model = new BookModel()
            {
                BookId = entity.BookId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                BarcodeNumber = entity.BarcodeNumber,
                PageCount = entity.PageCount,
                FirstPrintDate = entity.FirstPrintDate,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                AuthorId = entity.AuthorId,
                PublisherId = entity.PublisherId,
                SelectedCategories = entity.BookCategories.Select(i=>i.Category).ToList(),
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> BookEdit(BookModel model,int[] categoryIds,IFormFile file)
        {
            if(ModelState.IsValid)
            {
                var entity = _bookService.GetById(model.BookId);
                if(entity==null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Url = model.Url;
                entity.Price = model.Price;
                entity.Description = model.Description;
                entity.BarcodeNumber = model.BarcodeNumber;
                entity.PageCount = model.PageCount;
                entity.FirstPrintDate = model.FirstPrintDate;
                entity.AuthorId = model.AuthorId;
                entity.PublisherId =model.PublisherId;
                entity.IsApproved = model.IsApproved;
                entity.IsHome = model.IsHome;
                if(file!=null)
                {
                    entity.ImageUrl =file.FileName;
                    var extension = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);

                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                if(_bookService.Update(entity,categoryIds))
                {
                    TempData.Put("message",new AlertMessage(){
                    Title="The book has been updated.",
                    Message = $"{entity.Name} The book has been successfully updated.",
                    AlertType = "success"
                    });
                    return RedirectToAction("BookList");
                }
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        public IActionResult DeleteBook(int bookId)
        {
            var entity = _bookService.GetById(bookId);
            if(entity!=null)
            {
                _bookService.Delete(entity);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The book has been deleted.",
            Message = $"{entity.Name} The book has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("BookList");
        }


        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel{
                Categories = _categoryService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = new Category()
                {
                    Name = model.Name,
                    Url = model.Url,
                };
                _categoryService.Create(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The category has been added.",
                Message = $"{entity.Name} The category has been successfully added.",
                AlertType = "success"
                });
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetByIdWithBooks((int)id);
            if(entity==null)
            {
                return NotFound();

            }
            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                Url = entity.Url,
                Books = entity.BookCategories.Select(p=>p.Book).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CategoryEdit(CategoryModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = _categoryService.GetById(model.CategoryId);
                if(entity==null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                entity.Url = model.Url;
                _categoryService.Update(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The category has been updated.",
                Message = $"{entity.Name} The category has been successfully updated.",
                AlertType = "success"
                });
                return RedirectToAction("CategoryList");
            }
            return View(model);
            
        }
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if(entity!=null)
            {
                _categoryService.Delete(entity);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The category has been deleted.",
            Message = $"{entity.Name} The category has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult DeleteFromCategory(int bookId,int categoryId)
        {
            _categoryService.DeleteFromCategory(bookId,categoryId);
            return Redirect("/admin/categories/"+categoryId);
        }



        public IActionResult AuthorList()
        {
            return View(new BookListViewModel{
                Authors = _authorService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult AuthorCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AuthorCreate(AuthorModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = new Author()
                {
                    NameLastName = model.NameLastName,
                    Description = model.Description,
                };

                _authorService.Create(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The author has been added.",
                Message = $"{entity.NameLastName} The author has been successfully added.",
                AlertType = "success"
                });
                return RedirectToAction("AuthorList");
            }
            return View(model);
            
        }
        [HttpGet]
        public IActionResult AuthorEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var entity = _authorService.GetByIdWithBooks((int)id);

            if(entity==null)
            {
                return NotFound();

            }
            var model = new AuthorModel()
            {
                AuthorId = entity.AuthorId,
                NameLastName = entity.NameLastName,
                Description = entity.Description,
                Books = _bookService.GetAll().Where(c => c.AuthorId == id).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AuthorEdit(AuthorModel model,IFormFile file)
        {
            if(ModelState.IsValid)
            {
                var entity = _authorService.GetById(model.AuthorId);
                if(entity==null)
                {
                    return NotFound();
                }
                entity.NameLastName = model.NameLastName;
                entity.Description = model.Description;
                if(file!=null)
                {
                    entity.ImageUrl =file.FileName;
                    var extension = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{Guid.NewGuid()}{extension}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomName);

                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _authorService.Update(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The author has been updated.",
                Message = $"{entity.NameLastName} The author has been successfully updated.",
                AlertType = "success"
                });
                return RedirectToAction("AuthorList");
            }
            return View(model);
            
        }
        public IActionResult DeleteAuthor(int AuthorId)
        {
            var entity = _authorService.GetById(AuthorId);
            if(entity!=null)
            {
                _authorService.Delete(entity);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The author has been deleted.",
            Message = $"{entity.NameLastName} The author has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("AuthorList");
        }


        public IActionResult PublisherList()
        {
            return View(new BookListViewModel{
                Publishers = _publisherService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult PublisherCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PublisherCreate(PublisherModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = new Publisher()
                {
                    Name = model.Name
                };

                _publisherService.Create(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The publisher has been added.",
                Message = $"{entity.Name} The publisher has been successfully added.",
                AlertType = "success"
                });
                return RedirectToAction("PublisherList");
            }
            return View(model);
            
        }
        [HttpGet]
        public IActionResult PublisherEdit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var entity = _publisherService.GetByIdWithBooks((int)id);

            if(entity==null)
            {
                return NotFound();

            }
            var model = new PublisherModel()
            {
                PublisherId = entity.PublisherId,
                Name = entity.Name,
                Books = _bookService.GetAll().Where(c => c.PublisherId == id).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult PublisherEdit(PublisherModel model)
        {
            if(ModelState.IsValid)
            {
                var entity = _publisherService.GetById(model.PublisherId);
                if(entity==null)
                {
                    return NotFound();
                }
                entity.Name = model.Name;
                _publisherService.Update(entity);
                TempData.Put("message",new AlertMessage(){
                Title="The publisher has been updated.",
                Message = $"{entity.Name} The publisher has been successfully updated.",
                AlertType = "success"
                });
                return RedirectToAction("PublisherList");
            }
            return View(model);
        }
        public IActionResult DeletePublisher(int PublisherId)
        {
            var entity = _publisherService.GetById(PublisherId);
            if(entity!=null)
            {
                _publisherService.Delete(entity);
            }
            TempData.Put("message",new AlertMessage(){
            Title="The publisher has been deleted.",
            Message = $"{entity.Name} The publisher has been successfully deleted.",
            AlertType = "danger"
            });
            return RedirectToAction("PublisherList");
        }
    }

}
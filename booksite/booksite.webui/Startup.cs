using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.business.Concrete;
using booksite.data.Abstract;
using booksite.data.Concrete.EfCore;
using booksite.webui.EmailServices;
using booksite.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace booksite.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<ApplicationContext>(options=> options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddDbContext<ApplicationContext>(options=> options.UseSqlServer(_configuration.GetConnectionString("MsSqlConnection")));
            // services.AddDbContext<BookContext>(options=> options.UseSqlite(_configuration.GetConnectionString("SqliteConnection")));
            services.AddDbContext<BookContext>(options=> options.UseSqlServer(_configuration.GetConnectionString("MsSqlConnection")));
            services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options=> {
                // password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options=> {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".BookSite.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<IBookService,BookManager>();
            services.AddScoped<IAuthorService,AuthorManager>();
            services.AddScoped<IPublisherService,PublisherManager>();
            services.AddScoped<ICartService,CartManager>();
            services.AddScoped<IOrderService,OrderManager>();

            services.AddScoped<IEmailSender,SmtpEmailSender>(i=>
                new SmtpEmailSender(
                    _configuration["EmailSender:Host"],
                    _configuration.GetValue<int>("EmailSender:Port"),
                    _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    _configuration["EmailSender:UserName"],
                    _configuration["EmailSender:Password"]
                    )
                );

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IConfiguration configuration,UserManager<User> userManager,RoleManager<IdentityRole> roleManager,ICartService cartService)
        {
            app.UseStaticFiles(); // wwwroot

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"                
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "adminorders", 
                    pattern: "adminorders",
                    defaults: new {controller="Cart",action="GetByAdminOrders"}
                ); 
                endpoints.MapControllerRoute(
                    name: "orders", 
                    pattern: "orders",
                    defaults: new {controller="Cart",action="GetOrders"}
                ); 
                endpoints.MapControllerRoute(
                    name:"checkout",
                    pattern:"checkout",
                    defaults: new {controller="Cart",action="checkout"}
                );
                endpoints.MapControllerRoute(
                    name:"cart",
                    pattern:"cart",
                    defaults: new {controller="Cart",action="Index"}
                );
                endpoints.MapControllerRoute(
                    name:"adminusers",
                    pattern:"admin/user/list",
                    defaults: new {controller="Admin",action="UserList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminuseredit",
                    pattern:"admin/user/{id?}",
                    defaults: new {controller="Admin",action="UserEdit"}
                );
                endpoints.MapControllerRoute(
                    name:"adminusercreate",
                    pattern:"admin/user/create",
                    defaults: new {controller="Admin",action="UserCreate"}
                );


                endpoints.MapControllerRoute(
                    name:"adminroles",
                    pattern:"admin/role/list",
                    defaults: new {controller="Admin",action="RoleList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminrolecreate",
                    pattern:"admin/role/create",
                    defaults: new {controller="Admin",action="RoleCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"adminroleedit",
                    pattern:"admin/role/{id?}",
                    defaults: new {controller="Admin",action="RoleEdit"}
                );



                endpoints.MapControllerRoute(
                    name:"adminpublishers",
                    pattern:"admin/publishers",
                    defaults: new {controller="Admin",action="PublisherList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminpublishercreate",
                    pattern:"admin/publishers/create",
                    defaults: new {controller="Admin",action="PublisherCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"adminpublisheredit",
                    pattern:"admin/publishers/{id?}",
                    defaults: new {controller="Admin",action="PublisherEdit"}
                );

                
                endpoints.MapControllerRoute(
                    name:"adminauthors",
                    pattern:"admin/authors",
                    defaults: new {controller="Admin",action="AuthorList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminauthorcreate",
                    pattern:"admin/authors/create",
                    defaults: new {controller="Admin",action="AuthorCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"adminauthoredit",
                    pattern:"admin/authors/{id?}",
                    defaults: new {controller="Admin",action="AuthorEdit"}
                );
                

                
                endpoints.MapControllerRoute(
                    name:"adminbooks",
                    pattern:"admin/books",
                    defaults: new {controller="Admin",action="BookList"}
                );
                endpoints.MapControllerRoute(
                    name:"adminbookcreate",
                    pattern:"admin/books/create",
                    defaults: new {controller="Admin",action="BookCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"adminbookedit",
                    pattern:"admin/books/{id?}",
                    defaults: new {controller="Admin",action="BookEdit"}
                );
                endpoints.MapControllerRoute(
                    name:"admincategories",
                    pattern:"admin/categories",
                    defaults: new {controller="Admin",action="CategoryList"}
                );
                endpoints.MapControllerRoute(
                    name:"admincategorycreate",
                    pattern:"admin/categories/create",
                    defaults: new {controller="Admin",action="CategoryCreate"}
                );
                endpoints.MapControllerRoute(
                    name:"admincategoryedit",
                    pattern:"admin/categories/{id?}",
                    defaults: new {controller="Admin",action="CategoryEdit"}
                );
                
                endpoints.MapControllerRoute(
                    name:"search",
                    pattern:"search",
                    defaults: new {controller="Shop",action="search"}
                );
                endpoints.MapControllerRoute(
                    name:"contact",
                    pattern:"contact",
                    defaults: new {controller="Home",action="contact"}
                );
                endpoints.MapControllerRoute(
                    name:"about",
                    pattern:"about",
                    defaults: new {controller="Home",action="about"}
                );
                endpoints.MapControllerRoute(
                    name:"booksdetails",
                    pattern:"{url}",
                    defaults: new {controller="Shop",action="details"}
                );
                endpoints.MapControllerRoute(
                    name:"index",
                    pattern:"index/{category?}",
                    defaults: new {controller="Home",action="Index"}
                );
                endpoints.MapControllerRoute(
                    name:"books",
                    pattern:"books/{category?}",
                    defaults: new {controller="Shop",action="list"}
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name:"books/publisher",
                    pattern:"books/publisher/{id:int}",
                    defaults: new {controller="Shop",action="PublisherList"}
                );
                endpoints.MapControllerRoute(
                    name:"books/auhtor",
                    pattern:"books/author/{id:int}",
                    defaults: new {controller="Shop",action="AuthorList"}
                );
            });

            SeedIdentity.Seed(userManager,roleManager,cartService,configuration).Wait();
        
        }
    }
}

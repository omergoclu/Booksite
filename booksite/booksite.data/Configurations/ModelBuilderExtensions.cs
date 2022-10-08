using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book(){BookId=1,Name="Türlerin Kökeni",Url="turlerin-kokeni",Price=53,ImageUrl="1.jpg",Description="iyi bir kitap",IsApproved=true,BarcodeNumber="9786051715308",PageCount=687,FirstPrintDate="1998",AuthorId=1,PublisherId=1},
                new Book(){BookId=2,Name="Fareler ve İnsanlar",Url="fareler-ve-insanlar",Price=45,ImageUrl="2.jpg",Description="güzel kitap",IsApproved=true,BarcodeNumber="9789755705859",PageCount=243,FirstPrintDate="1995",AuthorId=2,PublisherId=2},
                new Book(){BookId=3,Name="Suç ve Ceza",Url="suc-ceza",Price=29,ImageUrl="3.jpg",Description="iyi bir kitap",IsApproved=true,BarcodeNumber="9789754589023",PageCount=256,FirstPrintDate="2014",AuthorId=3,PublisherId=3},
                new Book(){BookId=4,Name="Simyacı ",Url="simyaci",Price=85,ImageUrl="4.jpg",Description="iyi bir kitap",IsApproved=true,BarcodeNumber="9789750726439",PageCount=256,FirstPrintDate="2019",AuthorId=4,PublisherId=4},
                new Book(){BookId=5,Name="Hayvan Çifliği",Url="hayvan-ciftligi",Price=51,ImageUrl="5.jpg",Description="iyi bir kitap",IsApproved=true,BarcodeNumber="9789750719387",PageCount=256,FirstPrintDate="2013",AuthorId=5,PublisherId=5}
            );

            builder.Entity<Category>().HasData(
                new Category(){CategoryId=1,Name="Roman",Url="roman"},
                new Category(){CategoryId=2,Name="Bilim",Url="bilim"},
                new Category(){CategoryId=3,Name="Felsefe",Url="felsefe"},
                new Category(){CategoryId=4,Name="Dünya Roman",Url="dunya-roman"}
            );

            builder.Entity<BookCategory>().HasData(
            new BookCategory(){BookId=1,CategoryId=1},
            new BookCategory(){BookId=1,CategoryId=2},
            new BookCategory(){BookId=1,CategoryId=3},
            new BookCategory(){BookId=2,CategoryId=1},
            new BookCategory(){BookId=2,CategoryId=2},
            new BookCategory(){BookId=2,CategoryId=3},
            new BookCategory(){BookId=3,CategoryId=4},
            new BookCategory(){BookId=4,CategoryId=3},
            new BookCategory(){BookId=5,CategoryId=3},
            new BookCategory(){BookId=5,CategoryId=1}
           );

           builder.Entity<Publisher>().HasData(
                new Publisher(){PublisherId=1,Name="Alfa Yayıncılık"},
                new Publisher(){PublisherId=2,Name="Sel Yayıncılık"},
                new Publisher(){PublisherId=3,Name="İş Bankası"},
                new Publisher(){PublisherId=4,Name="Can Yayınları"},
                new Publisher(){PublisherId=5,Name="Timas Yayınları"}
            );

            builder.Entity<Author>().HasData(
                new Author(){AuthorId=1,NameLastName="Charles Darwin",ImageUrl="A1.jpg"},
                new Author(){AuthorId=2,NameLastName="John Steinbeck",ImageUrl="A2.jpg"},
                new Author(){AuthorId=3,NameLastName="Fyodor Dostoyevski",ImageUrl="A3.jpg"},
                new Author(){AuthorId=4,NameLastName="Paulo Coelho",ImageUrl="A4.jpg"},
                new Author(){AuthorId=5,NameLastName="George Orwell",ImageUrl="A5.jpg"}
            );
        }
    }
}
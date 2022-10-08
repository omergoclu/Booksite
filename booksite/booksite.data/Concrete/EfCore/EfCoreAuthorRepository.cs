using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCoreAuthorRepository: EfCoreGenericRepository<Author>, IAuthorRepository
    {
        public EfCoreAuthorRepository(BookContext context):base(context)
        {
            
        }
        private BookContext BookContext
        {
            get {return context as BookContext;}
        }

        

        public Author GetByIdWithBooks(int authorId)
        {
            return BookContext.Authors
                            .Include(c => c.Books)
                            .Where(i=>i.AuthorId==authorId)
                            .FirstOrDefault();
        }
    }
}
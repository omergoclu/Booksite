using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Abstract;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class EfCorePublisherRepository : EfCoreGenericRepository<Publisher>, IPublisherRepository
    {
        public EfCorePublisherRepository(BookContext context):base(context)
        {
            
        }
        private BookContext BookContext
        {
            get {return context as BookContext;}
        }
        public Publisher GetByIdWithBooks(int publisherId)
        {
            return BookContext.Publishers
                        .Include(i=>i.Books)
                        .Where(i=>i.PublisherId==publisherId)
                        .FirstOrDefault();
        }
    }
}
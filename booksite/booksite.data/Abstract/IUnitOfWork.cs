using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksite.data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        ICartRepository Carts {get;}
        ICategoryRepository Categories {get;}
        IOrderRepository Orders {get;}
        IBookRepository Books {get;}
        IAuthorRepository Authors {get;}
        IPublisherRepository Publishers {get;}
        void Save();

    }
}
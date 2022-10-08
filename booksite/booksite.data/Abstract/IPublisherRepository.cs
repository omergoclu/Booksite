using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.data.Abstract
{
    public interface IPublisherRepository:IRepository<Publisher>
    {
        Publisher GetByIdWithBooks(int publisherId);
    }
}
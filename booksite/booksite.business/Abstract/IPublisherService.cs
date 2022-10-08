using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface IPublisherService:IValidator<Publisher>
    {
        Publisher GetById(int id);
        Publisher GetByIdWithBooks(int publisherId);
        List<Publisher> GetAll();
        void Create(Publisher entity);
        void Update(Publisher entity);
        void Delete(Publisher entity);
    }
}
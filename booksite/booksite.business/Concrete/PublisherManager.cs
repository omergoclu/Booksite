using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.data.Abstract;
using booksite.entity;

namespace booksite.business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        private readonly IUnitOfWork _unitofwork;
        public PublisherManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Publisher entity)
        {
           _unitofwork.Publishers.Create(entity);
           _unitofwork.Save();
        }

        public void Delete(Publisher entity)
        {
            _unitofwork.Publishers.Delete(entity);
            _unitofwork.Save();
        }

        public List<Publisher> GetAll()
        {
            return _unitofwork.Publishers.GetAll();

        }

        public Publisher GetById(int id)
        {
            return _unitofwork.Publishers.GetById(id);
        }

        public Publisher GetByIdWithBooks(int publisherId)
        {
            return _unitofwork.Publishers.GetByIdWithBooks(publisherId);
        }
        
        public void Update(Publisher entity)
        {
            _unitofwork.Publishers.Update(entity);
            _unitofwork.Save();
        }

        public bool Validation(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}
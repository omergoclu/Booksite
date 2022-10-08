using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.data.Abstract;
using booksite.entity;

namespace booksite.business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IUnitOfWork _unitofwork;
        public AuthorManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Author entity)
        {
            _unitofwork.Authors.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Author entity)
        {
            _unitofwork.Authors.Delete(entity);
            _unitofwork.Save();

        }

        public List<Author> GetAll()
        {
            return _unitofwork.Authors.GetAll();

        }

        public Author GetById(int id)
        {
            return _unitofwork.Authors.GetById(id);
        }

        public Author GetByIdWithBooks(int authorId)
        {
            return _unitofwork.Authors.GetByIdWithBooks(authorId);
        }

        public void Update(Author entity)
        {
            _unitofwork.Authors.Update(entity);
            _unitofwork.Save();
            
        }

        public bool Validation(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
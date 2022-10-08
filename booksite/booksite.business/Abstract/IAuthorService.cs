using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.business.Abstract
{
    public interface IAuthorService:IValidator<Author>
    {
        Author GetById(int id);
        Author GetByIdWithBooks(int authorId);
        List<Author> GetAll();
        void Create(Author entity);
        void Update(Author entity);
        void Delete(Author entity);
    }
}
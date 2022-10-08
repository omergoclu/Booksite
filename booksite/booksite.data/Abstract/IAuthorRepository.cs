using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.entity;

namespace booksite.data.Abstract
{
    public interface IAuthorRepository:IRepository<Author>
    {
        Author GetByIdWithBooks(int authorId);
        
    }
}
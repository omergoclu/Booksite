using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.business.Abstract;
using booksite.data.Abstract;
using booksite.entity;

namespace booksite.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitofwork;
        public CategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create(Category entity)
        {
            _unitofwork.Categories.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Category entity)
        {
            _unitofwork.Categories.Delete(entity);
            _unitofwork.Save();
        }

        public void DeleteFromCategory(int bookId, int categoryId)
        {
            _unitofwork.Categories.DeleteFromCategory(bookId,categoryId);
        }

        public List<Category> GetAll()
        {
            return _unitofwork.Categories.GetAll();
        }

        public Category GetById(int id)
        {
            return _unitofwork.Categories.GetById(id);
        }

        public Category GetByIdWithBooks(int categoryId)
        {
            return _unitofwork.Categories.GetByIdWithBooks(categoryId);
        }

        public void Update(Category entity)
        {
            _unitofwork.Categories.Update(entity);
            _unitofwork.Save();
        }

        public bool Validation(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
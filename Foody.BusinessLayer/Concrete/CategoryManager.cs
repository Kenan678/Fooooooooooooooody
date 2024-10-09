using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService:::
    {
        private readonly ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }

        public List<Category> GetAll()
        {
           return _categoryService.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
;        }

        public void Insert(Category entity)
        {
           _categoryService.Insert(entity); 
        }

        public void Update(Category entity)
        {
          _categoryService.Update(entity);
    }
}

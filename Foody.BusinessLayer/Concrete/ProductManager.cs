﻿using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public   class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal ProductDal)
        {
            _productDal = ProductDal;
        }

        public void Delete(int id)
        {
            _productDal.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Insert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}

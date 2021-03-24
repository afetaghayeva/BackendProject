using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BackendProject.DataAccess.Abstract;
using BackendProject.Entities.Concrete;
using BackendProject.Entities.DTOs;

namespace BackendProject.DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        private readonly List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1,CategoryId = 1,ProductName = "Cup",UnitPrice = 15,UnitsInStock = 15},
                new Product {ProductId = 2,CategoryId = 2,ProductName = "Camera",UnitPrice = 500,UnitsInStock = 3},
                new Product {ProductId = 3,CategoryId = 2,ProductName = "Telephone",UnitPrice = 1500,UnitsInStock = 2},
                new Product {ProductId = 4,CategoryId = 2,ProductName = "Keyboard",UnitPrice = 150,UnitsInStock = 65},
                new Product {ProductId = 5,CategoryId = 2,ProductName = "Mouse",UnitPrice = 85,UnitsInStock = 1}
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
            }
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}

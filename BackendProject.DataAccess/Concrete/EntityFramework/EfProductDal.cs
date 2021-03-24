using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BackendProject.DataAccess.Abstract;
using BackendProject.Entities.Concrete;
using BackendProject.Entities.DTOs;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()       
        {
            using NorthwindContext context=new NorthwindContext();
            var result = from p in context.Products
                join c in context.Categories
                    on p.CategoryId equals c.CategoryId
                select new ProductDetailDto()
                {
                    ProductId = p.ProductId, CategoryName = c.CategoryName,
                    ProductName = p.ProductName, UnitsInStock = p.UnitsInStock
                };
            return result.ToList();
        }
    }
}

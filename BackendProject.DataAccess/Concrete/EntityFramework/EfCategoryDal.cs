using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BackendProject.DataAccess.Abstract;
using BackendProject.Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
       
    }
}

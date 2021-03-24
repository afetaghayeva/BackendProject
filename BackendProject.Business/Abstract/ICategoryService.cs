using System;
using System.Collections.Generic;
using System.Text;
using BackendProject.Entities.Concrete;
using Core.Utilities.Results;

namespace BackendProject.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}

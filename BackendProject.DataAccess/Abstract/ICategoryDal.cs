using System;
using System.Collections.Generic;
using System.Text;
using BackendProject.Entities.Concrete;
using Core.DataAccess;

namespace BackendProject.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        
    }
}

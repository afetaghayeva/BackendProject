using BackendProject.DataAccess.Abstract;
using BackendProject.Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}

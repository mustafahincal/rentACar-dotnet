using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
namespace DataAccess.Concrete.EntityFramework
{
      public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, CarRentalContext>, IUserOperationClaimDal
      {
      }
}

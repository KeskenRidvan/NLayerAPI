using Core.DataAccess.BaseRepository.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepository<Category, AppDbContext>, ICategoryDal
{
}

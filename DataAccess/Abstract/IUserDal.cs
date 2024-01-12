using Core.DataAccess.BaseRepository.Abstract;
using Core.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IUserDal : IEntityRepository<User>
{
	List<OperationClaim> GetClaims(User user);
}

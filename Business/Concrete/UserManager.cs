using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete;

public class UserManager : IUserService
{
	private readonly IUserDal _userDal;

	public UserManager(IUserDal userDal)
	{
		_userDal = userDal;
	}

	public List<OperationClaim> GetClaims(User user) => _userDal.GetClaims(user);

	public void Add(User user) => _userDal.Add(user);

	public User GetByMail(string email) => _userDal.Get(u => u.Email.Equals(email));

}

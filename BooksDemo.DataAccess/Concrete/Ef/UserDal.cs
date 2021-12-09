using BooksDemo.Core.DataAccess.Ef;
using BooksDemo.DataAccess.Abstract;
using BooksDemo.Entities.Concrete;

namespace BooksDemo.DataAccess.Concrete.Ef
{
	public class UserDal : EfEntityRepositoryBase<User, EntityContext>, IUserDal
	{

	}
}

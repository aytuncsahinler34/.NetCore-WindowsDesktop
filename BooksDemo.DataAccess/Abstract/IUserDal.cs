using BooksDemo.Core.DataAccess;
using BooksDemo.Entities.Concrete;

namespace BooksDemo.DataAccess.Abstract
{
	public interface IUserDal : IBaseRepository<User>
	{
	}
}

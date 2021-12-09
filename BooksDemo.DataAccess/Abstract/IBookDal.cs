using BooksDemo.Core.DataAccess;
using BooksDemo.Entities;

namespace BooksDemo.DataAccess.Abstract
{
	public interface IBookDal : IBaseRepository<Book>
	{
	}
}

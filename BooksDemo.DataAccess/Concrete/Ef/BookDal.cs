using BooksDemo.Core.DataAccess.Ef;
using BooksDemo.DataAccess.Abstract;
using BooksDemo.Entities;

namespace BooksDemo.DataAccess.Concrete.Ef
{
	public class BookDal : EfEntityRepositoryBase<Book, EntityContext>, IBookDal
	{

	}
}

using BooksDemo.Entities;
using System.Collections.Generic;

namespace BooksDemo.Business.Abstract
{
	public interface IBookService
	{
		Book GetById(int id);
		List<Book> GetAll();
		Book Add(Book entity);
		Book Update(Book entity);
		void Delete(int id);
	}
}

using BooksDemo.Business.Abstract;
using BooksDemo.DataAccess.Abstract;
using BooksDemo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BooksDemo.Business.Concrete
{
	public class BookService : IBookService
	{
		private IBookDal _bookDal;

		public BookService(IBookDal bookDal) {
			_bookDal = bookDal;
		}

		public Book GetById(int id) {
			return _bookDal.GetById(id);
		}

		public List<Book> GetAll() {
			return _bookDal.GetAll().ToList();
		}

		public Book Add(Book entity) {
			return _bookDal.Add(entity);
		}

		public void Delete(int id) {
			_bookDal.Delete(id);
		}

		public Book Update(Book entity) {
			return _bookDal.Update(entity);
		}
	}
}

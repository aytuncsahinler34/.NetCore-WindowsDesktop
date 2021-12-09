using BooksDemo.Entities.Concrete;
using System.Collections.Generic;

namespace BooksDemo.Business.Abstract
{
	public interface IUserService
	{
		User GetById(int id);
		List<User> GetAll();
		User Add(User entity);
		User Update(User entity);
		void Delete(int id);
	}
}

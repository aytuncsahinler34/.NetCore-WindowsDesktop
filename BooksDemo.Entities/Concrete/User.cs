using BooksDemo.Core.Entities;
using System;

namespace BooksDemo.Entities.Concrete
{
	public class User : DbObjectBase, IEntity
	{
		public string Name { get; set; }
		public long PhoneNumber { get; set; }
		public long NationalId { get; set; }
		public DateTime CheckOutDate { get; set; }
		public DateTime ReturnDate { get; set; }
	}
}

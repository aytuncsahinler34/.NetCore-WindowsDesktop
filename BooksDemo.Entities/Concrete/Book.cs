using BooksDemo.Core.Entities;
using BooksDemo.Entities.Concrete;

namespace BooksDemo.Entities
{
    public class Book : DbObjectBase, IEntity
    {
		public string BookTitle { get; set; }
		public long ISBN { get; set; }
		public int PublishYear { get; set; }
		public decimal CoverPrice { get; set; }
		public bool CheckStatus { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}

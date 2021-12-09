using BooksDemo.Entities;
using BooksDemo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BooksDemo.DataAccess.Concrete.Ef
{
	public class EntityContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("server=AYTUNC-PC\\SQLEXPRESS;database=BookDemo;integrated security=true;TrustServerCertificate=True");
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<User> Users { get; set; }

	}
}

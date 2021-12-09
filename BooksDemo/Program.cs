using BooksDemo.Business.Abstract;
using BooksDemo.Business.Concrete;
using BooksDemo.DataAccess.Abstract;
using BooksDemo.DataAccess.Concrete.Ef;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BooksDemo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var services = new ServiceCollection();

			ConfigureServices(services);
			using (ServiceProvider serviceProvider = services.BuildServiceProvider()) {
				var form1 = serviceProvider.GetRequiredService<Form1>();
				Application.Run(form1);
			}
		}

		private static void ConfigureServices(ServiceCollection services) {
			services.AddScoped<IBookService, BookService>();
			services.AddScoped<IBookDal, BookDal>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserDal, UserDal>();
			services.AddScoped<Form1>();
		}
	}
}

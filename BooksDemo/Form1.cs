using BooksDemo.Business.Abstract;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BooksDemo
{
	public partial class Form1 : Form
	{
		private readonly IBookService _bookService;
		private readonly IUserService _userService;
		public Form1(IBookService bookService, IUserService userService) 
		{
			_bookService = bookService;
			_userService = userService;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) 
		{
			//bu kod blogu dto şeklinde yapılabilirdi.
			var data = _bookService.GetAll().Select(x => new { 
			  x.BookTitle,
			  x.CheckStatus,
			  x.CoverPrice,
			  x.ISBN,
			  x.User.Name,
			  x.PublishYear
			});

			if (!data.Any()) 
			{
				dataGridView1.Columns[0].Visible = false;
			}
			else 
			{
				dataGridView1.DataSource = data;
			}

		}

		private void button3_Click(object sender, EventArgs e) {
			Form2 form2 = new Form2(_userService);
			form2.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			Form3 form3 = new Form3(_userService);
			form3.Show();
		}
	}
}

using BooksDemo.Business.Abstract;
using System;
using System.Windows.Forms;

namespace BooksDemo
{
	public partial class Form3 : Form
	{
		private readonly IUserService _userService;
		public Form3(IUserService userService) {
			_userService = userService;
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e) 
		{
			var data = _userService.GetAll();
		}
	}
}

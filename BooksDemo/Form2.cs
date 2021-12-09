using BooksDemo.Business.Abstract;
using BooksDemo.Entities.Concrete;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BooksDemo
{
	public partial class Form2 : Form
	{
		private readonly IUserService _userService;
		public Form2(IUserService userService) {
			_userService = userService;
			InitializeComponent();
			dateTimePicker2.Value = dateTimePicker1.Value.AddDays(15);
		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			if ((sender as TextBox).Text.Count(Char.IsDigit) >= 12)
				e.Handled = true;
		}

		private void button1_Click(object sender, EventArgs e) 
		{
			try 
			{
				if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text)) {
					MessageBox.Show("Fill in the required fields.");
					label7.Text = "Field is required";
					label8.Text = "Field is required";
					label9.Text = "Field is required";
					return;
				}

				if (!IsValidPhone(textBox3.Text)) {
					label7.Text = "Phone Number is Invalid";
					return;
				}

				User user = new User();
				user.Name = textBox2.Text;
				user.PhoneNumber = Convert.ToInt64(textBox3.Text);
				user.NationalId = Convert.ToInt64(textBox5.Text);
				user.CheckOutDate = DateTime.Now;
				user.ReturnDate = dateTimePicker2.Value;

				_userService.Add(user);

				MessageBox.Show("Success");
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		public bool IsValidPhone(string Phone) {
			try {
				if (string.IsNullOrEmpty(Phone))
					return false;
				var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
				return r.IsMatch(Phone);

			}
			catch (Exception) {
				throw;
			}
		}

	}
}

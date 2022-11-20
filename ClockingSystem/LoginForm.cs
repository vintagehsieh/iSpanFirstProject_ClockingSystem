using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClockingSystem.Infrastructures;
using ClockingSystem.Models;
using ComponentFactory.Krypton.Toolkit;

namespace ClockingSystem
{
	public partial class LoginForm : KryptonForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			//將表單欄位連結到view model
			LoginVM model = new LoginVM()
			{
				Account = accountTextBox.Text,
				Password = passwordTextBox.Text,
			};

			//對欄位進行驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox },
			};

			//bool isValid = Validate(model);
			bool isValid = ValidationHelper.Validate(model, map, errorProvider);
			if (!isValid) return;

			//判斷帳密是否正確
			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			//若正確就開啟MainForm
			//accountTextBox.Text = String.Empty;
			//passwordTextBox.Text = String.Empty;

			//var frm = new MainForm();
			//frm.Owner = this;

			//frm.Show();
			//this.Hide();
		}
	}
}

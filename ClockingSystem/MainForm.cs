using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Topshelf.Runtime.Windows;

namespace ClockingSystem
{
	public partial class MainForm : KryptonForm
	{
		private Form activeForm;

		public MainForm()
		{
			InitializeComponent();

			Greeting();
		}

		private void OpenChildForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.deskPanel.Controls.Add(childForm);
			this.deskPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			greetLabel.Text = string.Empty;
			headTitleLabel.Text = childForm.Text;
			headTitleLabel.Location = new Point(185, 9);
		}

		private void OpenMainForm(Form childForm, object btnSender)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.deskPanel.Controls.Add(childForm);
			this.deskPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			greetLabel.Text = Greeting();
			headTitleLabel.Text = "今天想來點？";
			headTitleLabel.Location = new Point(194, 9);
		}

		private void clockButton_Click(object sender, EventArgs e)
		{
			OpenChildForm(new ClockInOutForm(), sender);
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			OpenChildForm(new SearchForm(), sender);
		}

		

		private string Greeting()
		{
			var time = DateTime.Now;

			if (time.Hour > 5 && time.Hour < 12)
			{
				return greetLabel.Text = "早安！";
			}
			else if (time.Hour >= 12 && time.Hour < 18)
			{
				return greetLabel.Text = "午安！";
			}
			else
			{
				return greetLabel.Text = "晚安！";
			}
		}

		private void personButton_Click(object sender, EventArgs e)
		{
			OpenChildForm(new MaintainPersonForm(), sender);
		}

		private void leaveButton_Click(object sender, EventArgs e)
		{ 
			var frm = new LoginForm();
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}
		private void clockinPanel_Paint(object sender, PaintEventArgs e)
		{
		}

		private void returnButton_Click(object sender, EventArgs e)
		{
			OpenMainForm(new MainPicForm(), sender);
		}
	}
}


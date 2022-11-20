using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ClockingSystem
{
	public partial class ClockInOutForm : Form
	{
		public ClockInOutForm()
		{
			InitializeComponent();

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle,
												Color.FromArgb(50, 64,64,64), 2,ButtonBorderStyle.Solid,
												Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid,
												Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid,
												Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid);
		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle,
											Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid,
											Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid,
											Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid,
											Color.FromArgb(50, 64, 64, 64), 2, ButtonBorderStyle.Solid);
		}
	}
}

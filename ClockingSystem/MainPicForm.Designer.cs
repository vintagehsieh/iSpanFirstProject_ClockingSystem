namespace ClockingSystem
{
	partial class MainPicForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox.Image = global::ClockingSystem.Properties.Resources.hi;
			this.pictureBox.Location = new System.Drawing.Point(71, 25);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(422, 316);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// MainPicForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(572, 368);
			this.Controls.Add(this.pictureBox);
			this.Name = "MainPicForm";
			this.Text = "mainPicForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
	}
}
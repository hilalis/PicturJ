//Developed by @hilalis
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PicturJ
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		int timerb = 0;
		
		void Timer1Tick(object sender, EventArgs e)
		{
timerb = timerb+1;
			if(timerb == 1)
			{
				label2.Visible = true;
				label2.Text = "Maked window...";
			}
			if(timerb == 2)
			{
				label2.Text = "Maked text...";
			}
			if(timerb == 3)
			{
				label2.Text = "Maked Transparency...";
			}
			if(timerb == 4)
			{
				label2.Text = "Maked Design...";
			}
			if(timerb == 5)
			{
				label2.Text = "Starting...";
				timer1.Enabled = false;
				Form1 frm1 = new Form1();
				frm1.Show();
				this.Hide();
			
		}			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}

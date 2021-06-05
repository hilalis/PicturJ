//Developed by @hilalis
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;


namespace PicturJ
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string dosyaYolu = string.Empty;
		Bitmap bmp = null;	

Color renk;
		
		void NewProjectToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
dosyaYolu = openFileDialog1.FileName;
bmp = new Bitmap(dosyaYolu);
pictureBox1.Image = bmp;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox2.Visible = true;
			for(int y = 0; y<bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color eski = bmp.GetPixel(x,y);
					int ortalama = (eski.R + eski.G + eski.B) / 3;
					Color yeni = Color.FromArgb(eski.A, ortalama, ortalama, ortalama);
					bmp.SetPixel(x,y,yeni);
				}
			}
			pictureBox2.Visible = false;
			pictureBox1.Image = bmp;
saveFileDialog1.Filter = "JPEG Picture|.jpg";
saveFileDialog1.Title = "Export";
 saveFileDialog1.ShowDialog();
 if(saveFileDialog1.FileName!= "")
 {
 	FileStream savefile = (FileStream)saveFileDialog1.OpenFile();
 	pictureBox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Jpeg);
 }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
saveFileDialog1.Filter = "JPEG Picture|.jpg";
saveFileDialog1.Title = "Export Your Picture";
 saveFileDialog1.ShowDialog();
 if(saveFileDialog1.FileName!= "")
 {
 	FileStream savefile = (FileStream)saveFileDialog1.OpenFile();
 	pictureBox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Jpeg);
 }
		}
		
		
		
		void ExportToolStripMenuItemClick(object sender, EventArgs e)
		{
saveFileDialog1.Filter = "JPEG Picture|.jpg";
saveFileDialog1.Title = "Export Your Picture";
 saveFileDialog1.ShowDialog();
 if(saveFileDialog1.FileName!= "")
 {
 	FileStream savefile = (FileStream)saveFileDialog1.OpenFile();
 	pictureBox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Jpeg);
 }			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
panel1.Visible=true;
panel2.Visible=true;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			renk = colorDialog1.Color;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if(comboBox3.Text == "Regular")
			{
			if(renk != null && comboBox1.Text != "")
			bmp = new Bitmap(dosyaYolu);
			Graphics g = Graphics.FromImage(bmp);
			g.DrawString(textBox1.Text,new Font (comboBox2.Text,Convert.ToInt32(comboBox1.Text), FontStyle.Regular), new SolidBrush(renk),10,10);
			pictureBox1.Image = bmp;
			}
			if(comboBox3.Text == "Italic")
			{
			if(renk != null && comboBox1.Text != "")
			bmp = new Bitmap(dosyaYolu);
			Graphics g = Graphics.FromImage(bmp);
			g.DrawString(textBox1.Text,new Font (comboBox2.Text,Convert.ToInt32(comboBox1.Text), FontStyle.Italic), new SolidBrush(renk),10,10);
			pictureBox1.Image = bmp;
			}
			if(comboBox3.Text == "Bold")
			{
			if(renk != null && comboBox1.Text != "")
			bmp = new Bitmap(dosyaYolu);
			Graphics g = Graphics.FromImage(bmp);
			g.DrawString(textBox1.Text,new Font (comboBox2.Text,Convert.ToInt32(comboBox1.Text), FontStyle.Bold), new SolidBrush(renk),10,10);
			pictureBox1.Image = bmp;
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
							
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void GroupBox2Enter(object sender, EventArgs e)
		{
			
		}
		
		void HelpToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 about = new Form2();
			about.Show();
		 
		}
		
		void GermanyToolStripMenuItemClick(object sender, EventArgs e)
		{
			label1.Text = "Schriftgröße";
			label2.Text = "Schriftart";
			label3.Text = "Schriftstil";
			newProjectToolStripMenuItem.Text = "Datei öffnen";
			button5.Text = "anwenden";
			label6.Text = "Auswirkungen";
			button1.Text = "Monochrome";
			languagesToolStripMenuItem.Text = "Sprachen";
			helpToolStripMenuItem.Text = "Über";
			button3.Text = "Bild bearbeiten";
			saveFileDialog1.Title = "Export";
			button4.Text = "wähle eine Farbe";
			exportToolStripMenuItem.Text = "Ausfuhr";
			button2.Text = "Ausfuhr";
			label5.Text = "Wortlaut";
			label4.Text = "Text hinzufügen";
			button1.Text = "schwarzweiß";
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
	
		
		void РусскийЯзыкToolStripMenuItemClick(object sender, EventArgs e)
		{
			button3.Text = "Редактировать картинку";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_5
{

	public partial class MainForm : Form
	{
		
		string [] imagenes;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagenes = new string [5];
			string dir= "C:\\Users\\IPPESSI\\Downloads\\Lautaro Ruiz Diaz\\Planetas\\";
			imagenes[0]= dir + "tierra.jpg";
			imagenes[1]= dir + "urano.jpg";
			imagenes[2]= dir + "neptuno.jpg";
			imagenes[3]= dir + "jupiter.jpg";
			imagenes[4]= dir + "marte.jpg";
			
			pic_imagen.Image = Image.FromFile (imagenes[0]);
		}
		void Btn_randClick(object sender, EventArgs e)
		{
			var rand = new Random();
			pic_imagen.Image = Image.FromFile (imagenes[rand.Next(0,5)]);
		}

	}
}
  
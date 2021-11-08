/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 6/9/2021
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic_imagen;
		private System.Windows.Forms.Button btn_rand;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic_imagen = new System.Windows.Forms.PictureBox();
			this.btn_rand = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_imagen
			// 
			this.pic_imagen.Location = new System.Drawing.Point(50, 78);
			this.pic_imagen.Name = "pic_imagen";
			this.pic_imagen.Size = new System.Drawing.Size(488, 180);
			this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen.TabIndex = 5;
			this.pic_imagen.TabStop = false;
			// 
			// btn_rand
			// 
			this.btn_rand.Location = new System.Drawing.Point(249, 28);
			this.btn_rand.Name = "btn_rand";
			this.btn_rand.Size = new System.Drawing.Size(75, 23);
			this.btn_rand.TabIndex = 6;
			this.btn_rand.Text = "Click";
			this.btn_rand.UseVisualStyleBackColor = true;
			this.btn_rand.Click += new System.EventHandler(this.Btn_randClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 299);
			this.Controls.Add(this.btn_rand);
			this.Controls.Add(this.pic_imagen);
			this.Name = "MainForm";
			this.Text = "Ejercicio 5";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

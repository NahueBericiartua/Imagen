/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imagen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.PictureBox pic_imagen;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_ok = new System.Windows.Forms.Button();
			this.pic_imagen = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(72, 12);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(161, 67);
			this.btn_ok.TabIndex = 0;
			this.btn_ok.Text = "mostrar/ocultar";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_okClick);
			// 
			// pic_imagen
			// 
			this.pic_imagen.Image = ((System.Drawing.Image)(resources.GetObject("pic_imagen.Image")));
			this.pic_imagen.Location = new System.Drawing.Point(12, 85);
			this.pic_imagen.Name = "pic_imagen";
			this.pic_imagen.Size = new System.Drawing.Size(279, 193);
			this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen.TabIndex = 1;
			this.pic_imagen.TabStop = false;
			this.pic_imagen.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 290);
			this.Controls.Add(this.pic_imagen);
			this.Controls.Add(this.btn_ok);
			this.Name = "MainForm";
			this.Text = "Imagen";
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

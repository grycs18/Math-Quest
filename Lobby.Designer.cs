/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 5/14/2024
 * Time: 11:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HangMath
{
	partial class Lobby
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
			this.label4 = new System.Windows.Forms.Label();
			this.playerlabel1 = new System.Windows.Forms.Label();
			this.numtextBox1 = new System.Windows.Forms.TextBox();
			this.settimer1 = new System.Windows.Forms.Timer(this.components);
			this.timelabel1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.playtextBox1 = new System.Windows.Forms.TextBox();
			this.notiflabel1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.heartpictureBox3 = new System.Windows.Forms.PictureBox();
			this.heartpictureBox4 = new System.Windows.Forms.PictureBox();
			this.heartpictureBox5 = new System.Windows.Forms.PictureBox();
			this.setflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox5)).BeginInit();
			this.setflowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(11, 329);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 23);
			this.label4.TabIndex = 21;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// playerlabel1
			// 
			this.playerlabel1.BackColor = System.Drawing.Color.Transparent;
			this.playerlabel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.playerlabel1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerlabel1.ForeColor = System.Drawing.Color.White;
			this.playerlabel1.Location = new System.Drawing.Point(503, 329);
			this.playerlabel1.Name = "playerlabel1";
			this.playerlabel1.Size = new System.Drawing.Size(259, 26);
			this.playerlabel1.TabIndex = 19;
			this.playerlabel1.Click += new System.EventHandler(this.Playerlabel1Click);
			// 
			// numtextBox1
			// 
			this.numtextBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.numtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numtextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.numtextBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numtextBox1.ForeColor = System.Drawing.Color.White;
			this.numtextBox1.Location = new System.Drawing.Point(311, 62);
			this.numtextBox1.Multiline = true;
			this.numtextBox1.Name = "numtextBox1";
			this.numtextBox1.Size = new System.Drawing.Size(166, 46);
			this.numtextBox1.TabIndex = 22;
			this.numtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numtextBox1.TextChanged += new System.EventHandler(this.NumtextBox1TextChanged);
			// 
			// settimer1
			// 
			this.settimer1.Tick += new System.EventHandler(this.Settimer1Tick);
			// 
			// timelabel1
			// 
			this.timelabel1.BackColor = System.Drawing.Color.Transparent;
			this.timelabel1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timelabel1.ForeColor = System.Drawing.Color.White;
			this.timelabel1.Location = new System.Drawing.Point(300, 8);
			this.timelabel1.Name = "timelabel1";
			this.timelabel1.Size = new System.Drawing.Size(190, 23);
			this.timelabel1.TabIndex = 26;
			this.timelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.timelabel1.Click += new System.EventHandler(this.Timelabel1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(340, 265);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// playtextBox1
			// 
			this.playtextBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.playtextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.playtextBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playtextBox1.ForeColor = System.Drawing.Color.White;
			this.playtextBox1.Location = new System.Drawing.Point(12, 12);
			this.playtextBox1.Multiline = true;
			this.playtextBox1.Name = "playtextBox1";
			this.playtextBox1.Size = new System.Drawing.Size(118, 38);
			this.playtextBox1.TabIndex = 28;
			this.playtextBox1.Text = "0";
			this.playtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.playtextBox1.TextChanged += new System.EventHandler(this.PlaytextBox1TextChanged);
			// 
			// notiflabel1
			// 
			this.notiflabel1.BackColor = System.Drawing.Color.Transparent;
			this.notiflabel1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notiflabel1.ForeColor = System.Drawing.Color.Black;
			this.notiflabel1.Location = new System.Drawing.Point(300, 36);
			this.notiflabel1.Name = "notiflabel1";
			this.notiflabel1.Size = new System.Drawing.Size(190, 23);
			this.notiflabel1.TabIndex = 30;
			this.notiflabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.notiflabel1.Click += new System.EventHandler(this.Notiflabel1Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(153, 114);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(495, 201);
			this.panel1.TabIndex = 32;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// heartpictureBox3
			// 
			this.heartpictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.heartpictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("heartpictureBox3.Image")));
			this.heartpictureBox3.Location = new System.Drawing.Point(11, 62);
			this.heartpictureBox3.Name = "heartpictureBox3";
			this.heartpictureBox3.Size = new System.Drawing.Size(52, 45);
			this.heartpictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.heartpictureBox3.TabIndex = 33;
			this.heartpictureBox3.TabStop = false;
			this.heartpictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// heartpictureBox4
			// 
			this.heartpictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.heartpictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("heartpictureBox4.Image")));
			this.heartpictureBox4.Location = new System.Drawing.Point(12, 107);
			this.heartpictureBox4.Name = "heartpictureBox4";
			this.heartpictureBox4.Size = new System.Drawing.Size(52, 45);
			this.heartpictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.heartpictureBox4.TabIndex = 34;
			this.heartpictureBox4.TabStop = false;
			this.heartpictureBox4.Click += new System.EventHandler(this.HeartpictureBox4Click);
			// 
			// heartpictureBox5
			// 
			this.heartpictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.heartpictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("heartpictureBox5.Image")));
			this.heartpictureBox5.Location = new System.Drawing.Point(11, 151);
			this.heartpictureBox5.Name = "heartpictureBox5";
			this.heartpictureBox5.Size = new System.Drawing.Size(52, 45);
			this.heartpictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.heartpictureBox5.TabIndex = 35;
			this.heartpictureBox5.TabStop = false;
			this.heartpictureBox5.Click += new System.EventHandler(this.HeartpictureBox5Click);
			// 
			// setflowLayoutPanel1
			// 
			this.setflowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.setflowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.setflowLayoutPanel1.Controls.Add(this.pictureBox2);
			this.setflowLayoutPanel1.Controls.Add(this.checkBox1);
			this.setflowLayoutPanel1.Controls.Add(this.button3);
			this.setflowLayoutPanel1.Controls.Add(this.checkBox2);
			this.setflowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.setflowLayoutPanel1.Location = new System.Drawing.Point(662, 36);
			this.setflowLayoutPanel1.Name = "setflowLayoutPanel1";
			this.setflowLayoutPanel1.Size = new System.Drawing.Size(110, 220);
			this.setflowLayoutPanel1.TabIndex = 37;
			this.setflowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SetflowLayoutPanel1Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 88);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(3, 97);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 32);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Mute";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.button3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(3, 135);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 32);
			this.button3.TabIndex = 1;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.checkBox2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.ForeColor = System.Drawing.Color.White;
			this.checkBox2.Location = new System.Drawing.Point(3, 173);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(96, 32);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Exit";
			this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox2.UseVisualStyleBackColor = false;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// linkLabel2
			// 
			this.linkLabel2.ActiveLinkColor = System.Drawing.Color.SaddleBrown;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel2.ForeColor = System.Drawing.Color.White;
			this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkLabel2.LinkColor = System.Drawing.Color.White;
			this.linkLabel2.Location = new System.Drawing.Point(662, 8);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(100, 23);
			this.linkLabel2.TabIndex = 38;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Settings";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// Lobby
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(774, 362);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.setflowLayoutPanel1);
			this.Controls.Add(this.heartpictureBox5);
			this.Controls.Add(this.heartpictureBox4);
			this.Controls.Add(this.heartpictureBox3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.notiflabel1);
			this.Controls.Add(this.playtextBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.timelabel1);
			this.Controls.Add(this.numtextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.playerlabel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.KeyPreview = true;
			this.Name = "Lobby";
			this.Text = "Lobby";
			this.Load += new System.EventHandler(this.LobbyLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heartpictureBox5)).EndInit();
			this.setflowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.FlowLayoutPanel setflowLayoutPanel1;
		private System.Windows.Forms.PictureBox heartpictureBox5;
		private System.Windows.Forms.PictureBox heartpictureBox4;
		private System.Windows.Forms.PictureBox heartpictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label notiflabel1;
		private System.Windows.Forms.TextBox playtextBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label timelabel1;
		private System.Windows.Forms.Timer settimer1;
		private System.Windows.Forms.TextBox numtextBox1;
		private System.Windows.Forms.Label playerlabel1;
		private System.Windows.Forms.Label label4;
	}
}

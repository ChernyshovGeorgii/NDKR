
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class Kval
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kval));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.tbKv = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.CloseBtn);
			this.groupBox1.Controls.Add(this.AddBtn);
			this.groupBox1.Controls.Add(this.tbKv);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 118);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление данных";
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(280, 63);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 11;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.White;
			this.AddBtn.Location = new System.Drawing.Point(9, 63);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 10;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// tbKv
			// 
			this.tbKv.Location = new System.Drawing.Point(159, 31);
			this.tbKv.Name = "tbKv";
			this.tbKv.Size = new System.Drawing.Size(196, 20);
			this.tbKv.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введение данных:";
			// 
			// Kval
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 150);
			this.Controls.Add(this.groupBox1);
			this.Name = "Kval";
			this.Text = "Kval";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox tbKv;
		private System.Windows.Forms.Label label1;
	}
}
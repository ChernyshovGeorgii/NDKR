
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class AddForm3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm3));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.tbOtch = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbFam = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.CloseBtn);
			this.groupBox1.Controls.Add(this.AddBtn);
			this.groupBox1.Controls.Add(this.tbOtch);
			this.groupBox1.Controls.Add(this.tbName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbFam);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 157);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление данных";
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(280, 121);
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
			this.AddBtn.Location = new System.Drawing.Point(9, 121);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 10;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// tbOtch
			// 
			this.tbOtch.Location = new System.Drawing.Point(159, 88);
			this.tbOtch.Name = "tbOtch";
			this.tbOtch.Size = new System.Drawing.Size(196, 20);
			this.tbOtch.TabIndex = 7;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(159, 59);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(196, 20);
			this.tbName.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Отчество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Имя";
			// 
			// tbFam
			// 
			this.tbFam.Location = new System.Drawing.Point(159, 31);
			this.tbFam.Name = "tbFam";
			this.tbFam.Size = new System.Drawing.Size(196, 20);
			this.tbFam.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фамилия";
			// 
			// AddForm3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 180);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddForm3";
			this.Text = "AddForm3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.TextBox tbOtch;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbFam;
		private System.Windows.Forms.Label label1;
	}
}
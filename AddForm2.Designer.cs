
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class AddForm2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm2));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFam = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbOtch = new System.Windows.Forms.TextBox();
			this.tbPass = new System.Windows.Forms.TextBox();
			this.tbDt = new System.Windows.Forms.TextBox();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.CloseBtn);
			this.groupBox1.Controls.Add(this.AddBtn);
			this.groupBox1.Controls.Add(this.tbDt);
			this.groupBox1.Controls.Add(this.tbPass);
			this.groupBox1.Controls.Add(this.tbOtch);
			this.groupBox1.Controls.Add(this.tbName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbFam);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление данных";
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
			// tbFam
			// 
			this.tbFam.Location = new System.Drawing.Point(159, 31);
			this.tbFam.Name = "tbFam";
			this.tbFam.Size = new System.Drawing.Size(196, 20);
			this.tbFam.TabIndex = 1;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Паспортные данные";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Дата рождения";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(159, 59);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(196, 20);
			this.tbName.TabIndex = 6;
			// 
			// tbOtch
			// 
			this.tbOtch.Location = new System.Drawing.Point(159, 88);
			this.tbOtch.Name = "tbOtch";
			this.tbOtch.Size = new System.Drawing.Size(196, 20);
			this.tbOtch.TabIndex = 7;
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(159, 116);
			this.tbPass.Name = "tbPass";
			this.tbPass.Size = new System.Drawing.Size(196, 20);
			this.tbPass.TabIndex = 8;
			// 
			// tbDt
			// 
			this.tbDt.Location = new System.Drawing.Point(159, 147);
			this.tbDt.Name = "tbDt";
			this.tbDt.Size = new System.Drawing.Size(196, 20);
			this.tbDt.TabIndex = 9;
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(280, 185);
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
			this.AddBtn.Location = new System.Drawing.Point(9, 185);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 10;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// AddForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(416, 251);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddForm2";
			this.Text = "AddForm2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbFam;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDt;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.TextBox tbOtch;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.Button AddBtn;
	}
}
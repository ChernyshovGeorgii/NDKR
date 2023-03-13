
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class AddForm5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm5));
			this.label1 = new System.Windows.Forms.Label();
			this.tbPost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbNmb = new System.Windows.Forms.TextBox();
			this.tbKol = new System.Windows.Forms.TextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Дата поставки";
			// 
			// tbPost
			// 
			this.tbPost.Location = new System.Drawing.Point(159, 31);
			this.tbPost.Name = "tbPost";
			this.tbPost.Size = new System.Drawing.Size(196, 20);
			this.tbPost.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Номер договора";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Количество товара";
			// 
			// tbNmb
			// 
			this.tbNmb.Location = new System.Drawing.Point(159, 59);
			this.tbNmb.Name = "tbNmb";
			this.tbNmb.Size = new System.Drawing.Size(196, 20);
			this.tbNmb.TabIndex = 6;
			// 
			// tbKol
			// 
			this.tbKol.Location = new System.Drawing.Point(159, 88);
			this.tbKol.Name = "tbKol";
			this.tbKol.Size = new System.Drawing.Size(196, 20);
			this.tbKol.TabIndex = 7;
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.White;
			this.AddBtn.Location = new System.Drawing.Point(6, 118);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 10;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(280, 118);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 11;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.CloseBtn);
			this.groupBox1.Controls.Add(this.AddBtn);
			this.groupBox1.Controls.Add(this.tbKol);
			this.groupBox1.Controls.Add(this.tbNmb);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbPost);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(387, 157);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Добавление данных";
			// 
			// AddForm5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 184);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddForm5";
			this.Text = "AddForm5";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbNmb;
		private System.Windows.Forms.TextBox tbKol;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
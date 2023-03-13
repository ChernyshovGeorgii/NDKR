
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
    partial class SearchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.tbStr = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.SearchButton);
			this.groupBox1.Controls.Add(this.CloseBtn);
			this.groupBox1.Controls.Add(this.tbStr);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(429, 143);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите данные для поиска";
			// 
			// SearchButton
			// 
			this.SearchButton.BackColor = System.Drawing.Color.White;
			this.SearchButton.Location = new System.Drawing.Point(6, 114);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(75, 23);
			this.SearchButton.TabIndex = 2;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = false;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.BackColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(340, 114);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// tbStr
			// 
			this.tbStr.Location = new System.Drawing.Point(6, 53);
			this.tbStr.Name = "tbStr";
			this.tbStr.Size = new System.Drawing.Size(409, 20);
			this.tbStr.TabIndex = 0;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(453, 166);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchForm";
			this.Text = "AddForm2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox tbStr;
    }
}
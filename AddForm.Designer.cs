
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1 = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KlientTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVrIDt = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ИС_Фитнес_клуба_Athlete_FitnessDataSet1
            // 
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1.DataSetName = "_ИС_Фитнес_клуба_Athlete_FitnessDataSet";
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbVrIDt);
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление данных";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Время и дата записи:";
            // 
            // tbVrIDt
            // 
            this.tbVrIDt.Location = new System.Drawing.Point(175, 25);
            this.tbVrIDt.Name = "tbVrIDt";
            this.tbVrIDt.Size = new System.Drawing.Size(162, 20);
            this.tbVrIDt.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(262, 72);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(6, 72);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(367, 137);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private _ИС_Фитнес_клуба_Athlete_FitnessDataSet _ИС_Фитнес_клуба_Athlete_FitnessDataSet1;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVrIDt;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}
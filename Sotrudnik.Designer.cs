
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class Sotrudnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotrudnik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kvalifikaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.SotrudnikTableAdapter();
            this.kvalifikaciaTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KvalifikaciaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kvalifikaciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolzhnostTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.DolzhnostTableAdapter();
            this.iDSotrudnkiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Должность = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Квалификация = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDKvalifikaciiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namekvalifikaciiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikaciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrudnkiaDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.Должность,
            this.Квалификация});
            this.dataGridView1.DataSource = this.sotrudnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // kvalifikaciaBindingSource
            // 
            this.kvalifikaciaBindingSource.DataMember = "Kvalifikacia";
            this.kvalifikaciaBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // _ИС_Фитнес_клуба_Athlete_FitnessDataSet
            // 
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.DataSetName = "_ИС_Фитнес_клуба_Athlete_FitnessDataSet";
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // kvalifikaciaTableAdapter
            // 
            this.kvalifikaciaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKvalifikaciiDataGridViewTextBoxColumn,
            this.namekvalifikaciiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kvalifikaciaBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(727, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(262, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // kvalifikaciaBindingSource1
            // 
            this.kvalifikaciaBindingSource1.DataMember = "Kvalifikacia";
            this.kvalifikaciaBindingSource1.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(727, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(146, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Поиск данных";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(988, 477);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(261, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Сохранить данные";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(861, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Сохранить данные";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // iDSotrudnkiaDataGridViewTextBoxColumn
            // 
            this.iDSotrudnkiaDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnkia";
            this.iDSotrudnkiaDataGridViewTextBoxColumn.HeaderText = "Номер сотрудника";
            this.iDSotrudnkiaDataGridViewTextBoxColumn.Name = "iDSotrudnkiaDataGridViewTextBoxColumn";
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "Imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // Должность
            // 
            this.Должность.DataPropertyName = "ID_Dolzhnosti";
            this.Должность.DataSource = this.dolzhnostBindingSource;
            this.Должность.DisplayMember = "Name_dolzhnosti";
            this.Должность.HeaderText = "Должность";
            this.Должность.Name = "Должность";
            this.Должность.ValueMember = "ID_Dolzhnosti";
            // 
            // Квалификация
            // 
            this.Квалификация.DataPropertyName = "ID_Kvalifikacii";
            this.Квалификация.DataSource = this.kvalifikaciaBindingSource;
            this.Квалификация.DisplayMember = "Name_kvalifikacii";
            this.Квалификация.HeaderText = "Квалификация";
            this.Квалификация.Name = "Квалификация";
            this.Квалификация.ValueMember = "ID_Kvalifikacii";
            // 
            // iDKvalifikaciiDataGridViewTextBoxColumn
            // 
            this.iDKvalifikaciiDataGridViewTextBoxColumn.DataPropertyName = "ID_Kvalifikacii";
            this.iDKvalifikaciiDataGridViewTextBoxColumn.HeaderText = "Номер квалификации";
            this.iDKvalifikaciiDataGridViewTextBoxColumn.Name = "iDKvalifikaciiDataGridViewTextBoxColumn";
            // 
            // namekvalifikaciiDataGridViewTextBoxColumn
            // 
            this.namekvalifikaciiDataGridViewTextBoxColumn.DataPropertyName = "Name_kvalifikacii";
            this.namekvalifikaciiDataGridViewTextBoxColumn.HeaderText = "Название квалификации";
            this.namekvalifikaciiDataGridViewTextBoxColumn.Name = "namekvalifikaciiDataGridViewTextBoxColumn";
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 512);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sotrudnik";
            this.Text = "Sotrudnik";
            this.Load += new System.EventHandler(this.Sotrudnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvalifikaciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSet _ИС_Фитнес_клуба_Athlete_FitnessDataSet;
		public System.Windows.Forms.BindingSource sotrudnikBindingSource;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
		public System.Windows.Forms.BindingSource kvalifikaciaBindingSource;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KvalifikaciaTableAdapter kvalifikaciaTableAdapter;
		public System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource kvalifikaciaBindingSource1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnkiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Должность;
        private System.Windows.Forms.DataGridViewComboBoxColumn Квалификация;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKvalifikaciiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namekvalifikaciiDataGridViewTextBoxColumn;
    }
}
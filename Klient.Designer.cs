
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class Klient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.polBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KlientTableAdapter();
            this.polTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.PolTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.polBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.iDPolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportniedannyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarozhdenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKlientaDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.pasportniedannyeDataGridViewTextBoxColumn,
            this.datarozhdenyaDataGridViewTextBoxColumn,
            this.Пол});
            this.dataGridView1.DataSource = this.klientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 565);
            this.dataGridView1.TabIndex = 0;
            // 
            // polBindingSource
            // 
            this.polBindingSource.DataMember = "Pol";
            this.polBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // _ИС_Фитнес_клуба_Athlete_FitnessDataSet
            // 
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.DataSetName = "_ИС_Фитнес_клуба_Athlete_FitnessDataSet";
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // polTableAdapter
            // 
            this.polTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(146, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Поиск данных";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPolaDataGridViewTextBoxColumn,
            this.namePolaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.polBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(812, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(262, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // polBindingSource1
            // 
            this.polBindingSource1.DataMember = "Pol";
            this.polBindingSource1.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(812, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(981, 584);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(261, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Сохранить данные";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(946, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Сохранить данные";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // iDPolaDataGridViewTextBoxColumn
            // 
            this.iDPolaDataGridViewTextBoxColumn.DataPropertyName = "ID_Pola";
            this.iDPolaDataGridViewTextBoxColumn.HeaderText = "Номер пола";
            this.iDPolaDataGridViewTextBoxColumn.Name = "iDPolaDataGridViewTextBoxColumn";
            // 
            // namePolaDataGridViewTextBoxColumn
            // 
            this.namePolaDataGridViewTextBoxColumn.DataPropertyName = "Name pola";
            this.namePolaDataGridViewTextBoxColumn.HeaderText = "Название пола";
            this.namePolaDataGridViewTextBoxColumn.Name = "namePolaDataGridViewTextBoxColumn";
            // 
            // iDKlientaDataGridViewTextBoxColumn
            // 
            this.iDKlientaDataGridViewTextBoxColumn.DataPropertyName = "ID_Klienta";
            this.iDKlientaDataGridViewTextBoxColumn.HeaderText = "Номер клиента";
            this.iDKlientaDataGridViewTextBoxColumn.Name = "iDKlientaDataGridViewTextBoxColumn";
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
            // pasportniedannyeDataGridViewTextBoxColumn
            // 
            this.pasportniedannyeDataGridViewTextBoxColumn.DataPropertyName = "Pasportnie_dannye";
            this.pasportniedannyeDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.pasportniedannyeDataGridViewTextBoxColumn.Name = "pasportniedannyeDataGridViewTextBoxColumn";
            // 
            // datarozhdenyaDataGridViewTextBoxColumn
            // 
            this.datarozhdenyaDataGridViewTextBoxColumn.DataPropertyName = "Data_rozhdenya";
            this.datarozhdenyaDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.datarozhdenyaDataGridViewTextBoxColumn.Name = "datarozhdenyaDataGridViewTextBoxColumn";
            // 
            // Пол
            // 
            this.Пол.DataPropertyName = "ID_Pola";
            this.Пол.DataSource = this.polBindingSource;
            this.Пол.DisplayMember = "Name pola";
            this.Пол.HeaderText = "Пол";
            this.Пол.Name = "Пол";
            this.Пол.ValueMember = "ID_Pola";
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 619);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Klient";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.Klient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSet _ИС_Фитнес_клуба_Athlete_FitnessDataSet;
		private System.Windows.Forms.BindingSource klientBindingSource;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
		public System.Windows.Forms.BindingSource polBindingSource;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.PolTableAdapter polTableAdapter;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource polBindingSource1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportniedannyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarozhdenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Пол;
    }
}
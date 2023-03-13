
namespace ИС_Фитнес_клуба_Athlete_Fitness
{
	partial class PostTov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.postavkatovaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSet();
            this.postavka_tovaraTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Postavka_tovaraTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.SotrudnikTableAdapter();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.PostavshikTableAdapter();
            this.statyssortirovkiirasfasovkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statys_sortirovki_i_rasfasovkiTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Statys_sortirovki_i_rasfasovkiTableAdapter();
            this.tipoplatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_oplatiTableAdapter = new ИС_Фитнес_клуба_Athlete_Fitness._ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Tip_oplatiTableAdapter();
            this.iDPostavkitovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerdogovoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvotovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sotrudnika = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Postavshika = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Statysa_sortirovki_i_rasfasovki = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Tipa_oplati = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkatovaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statyssortirovkiirasfasovkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostavkitovaraDataGridViewTextBoxColumn,
            this.datapostavkiDataGridViewTextBoxColumn,
            this.nomerdogovoraDataGridViewTextBoxColumn,
            this.kolichestvotovaraDataGridViewTextBoxColumn,
            this.ID_Sotrudnika,
            this.ID_Postavshika,
            this.ID_Statysa_sortirovki_i_rasfasovki,
            this.ID_Tipa_oplati});
            this.dataGridView1.DataSource = this.postavkatovaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // postavkatovaraBindingSource
            // 
            this.postavkatovaraBindingSource.DataMember = "Postavka_tovara";
            this.postavkatovaraBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // _ИС_Фитнес_клуба_Athlete_FitnessDataSet
            // 
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.DataSetName = "_ИС_Фитнес_клуба_Athlete_FitnessDataSet";
            this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavka_tovaraTableAdapter
            // 
            this.postavka_tovaraTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(146, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Поиск данных";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(992, 429);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(261, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Сохранить данные";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // statyssortirovkiirasfasovkiBindingSource
            // 
            this.statyssortirovkiirasfasovkiBindingSource.DataMember = "Statys_sortirovki_i_rasfasovki";
            this.statyssortirovkiirasfasovkiBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // statys_sortirovki_i_rasfasovkiTableAdapter
            // 
            this.statys_sortirovki_i_rasfasovkiTableAdapter.ClearBeforeFill = true;
            // 
            // tipoplatiBindingSource
            // 
            this.tipoplatiBindingSource.DataMember = "Tip_oplati";
            this.tipoplatiBindingSource.DataSource = this._ИС_Фитнес_клуба_Athlete_FitnessDataSet;
            // 
            // tip_oplatiTableAdapter
            // 
            this.tip_oplatiTableAdapter.ClearBeforeFill = true;
            // 
            // iDPostavkitovaraDataGridViewTextBoxColumn
            // 
            this.iDPostavkitovaraDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavki_tovara";
            this.iDPostavkitovaraDataGridViewTextBoxColumn.HeaderText = "Номер поставки товара";
            this.iDPostavkitovaraDataGridViewTextBoxColumn.Name = "iDPostavkitovaraDataGridViewTextBoxColumn";
            // 
            // datapostavkiDataGridViewTextBoxColumn
            // 
            this.datapostavkiDataGridViewTextBoxColumn.DataPropertyName = "Data_postavki";
            this.datapostavkiDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.datapostavkiDataGridViewTextBoxColumn.Name = "datapostavkiDataGridViewTextBoxColumn";
            // 
            // nomerdogovoraDataGridViewTextBoxColumn
            // 
            this.nomerdogovoraDataGridViewTextBoxColumn.DataPropertyName = "Nomer_dogovora";
            this.nomerdogovoraDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.nomerdogovoraDataGridViewTextBoxColumn.Name = "nomerdogovoraDataGridViewTextBoxColumn";
            // 
            // kolichestvotovaraDataGridViewTextBoxColumn
            // 
            this.kolichestvotovaraDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo_tovara";
            this.kolichestvotovaraDataGridViewTextBoxColumn.HeaderText = "Кол-во товара";
            this.kolichestvotovaraDataGridViewTextBoxColumn.Name = "kolichestvotovaraDataGridViewTextBoxColumn";
            // 
            // ID_Sotrudnika
            // 
            this.ID_Sotrudnika.DataPropertyName = "ID_Sotrudnika";
            this.ID_Sotrudnika.DataSource = this.sotrudnikBindingSource;
            this.ID_Sotrudnika.DisplayMember = "Familiya";
            this.ID_Sotrudnika.HeaderText = "Сотрудник";
            this.ID_Sotrudnika.Name = "ID_Sotrudnika";
            this.ID_Sotrudnika.ValueMember = "ID_Sotrudnkia";
            // 
            // ID_Postavshika
            // 
            this.ID_Postavshika.DataPropertyName = "ID_Postavshika";
            this.ID_Postavshika.DataSource = this.postavshikBindingSource;
            this.ID_Postavshika.DisplayMember = "Familiya";
            this.ID_Postavshika.HeaderText = "Поставщик";
            this.ID_Postavshika.Name = "ID_Postavshika";
            this.ID_Postavshika.ValueMember = "ID_Postavshika";
            // 
            // ID_Statysa_sortirovki_i_rasfasovki
            // 
            this.ID_Statysa_sortirovki_i_rasfasovki.DataPropertyName = "ID_Statysa_sortirovki_i_rasfasovki";
            this.ID_Statysa_sortirovki_i_rasfasovki.DataSource = this.statyssortirovkiirasfasovkiBindingSource;
            this.ID_Statysa_sortirovki_i_rasfasovki.DisplayMember = "Name_statysa_sortirovki_i_rasfasovki";
            this.ID_Statysa_sortirovki_i_rasfasovki.HeaderText = "Статус сортировки и расфасовки";
            this.ID_Statysa_sortirovki_i_rasfasovki.Name = "ID_Statysa_sortirovki_i_rasfasovki";
            this.ID_Statysa_sortirovki_i_rasfasovki.ValueMember = "ID_Statysa_sortirovki_i_rasfasovki";
            // 
            // ID_Tipa_oplati
            // 
            this.ID_Tipa_oplati.DataPropertyName = "ID_Tipa_oplati";
            this.ID_Tipa_oplati.DataSource = this.tipoplatiBindingSource;
            this.ID_Tipa_oplati.DisplayMember = "Name_tipa_oplati";
            this.ID_Tipa_oplati.HeaderText = "Тип оплаты";
            this.ID_Tipa_oplati.Name = "ID_Tipa_oplati";
            this.ID_Tipa_oplati.ValueMember = "ID_Tipa_oplati";
            // 
            // PostTov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 469);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PostTov";
            this.Text = "PostTov";
            this.Load += new System.EventHandler(this.PostTov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkatovaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statyssortirovkiirasfasovkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoplatiBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSet _ИС_Фитнес_клуба_Athlete_FitnessDataSet;
		public System.Windows.Forms.BindingSource postavkatovaraBindingSource;
		public _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Postavka_tovaraTableAdapter postavka_tovaraTableAdapter;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.BindingSource statyssortirovkiirasfasovkiBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Statys_sortirovki_i_rasfasovkiTableAdapter statys_sortirovki_i_rasfasovkiTableAdapter;
        private System.Windows.Forms.BindingSource tipoplatiBindingSource;
        private _ИС_Фитнес_клуба_Athlete_FitnessDataSetTableAdapters.Tip_oplatiTableAdapter tip_oplatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavkitovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerdogovoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvotovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnika;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Postavshika;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Statysa_sortirovki_i_rasfasovki;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tipa_oplati;
    }
}
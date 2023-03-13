using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_Фитнес_клуба_Athlete_Fitness
{
    public partial class OrgZan : Form
    {
        public OrgZan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Plan_zanyatia". При необходимости она может быть перемещена или удалена.
            this.plan_zanyatiaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Plan_zanyatia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_zanyatia". При необходимости она может быть перемещена или удалена.
            this.tip_zanyatiaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_zanyatia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati". При необходимости она может быть перемещена или удалена.
            this.statys_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Organizatsya_zanyatii". При необходимости она может быть перемещена или удалена.
            this.organizatsya_zanyatiiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Organizatsya_zanyatii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Pol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kvalifikacia". При необходимости она может быть перемещена или удалена.
            this.kvalifikaciaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kvalifikacia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Dolzhnost);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            organizatsyazanyatiiBindingSource.EndEdit();
            organizatsya_zanyatiiTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet2);
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            planzanyatiaBindingSource.EndEdit();
            plan_zanyatiaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            tipzanyatiaBindingSource.EndEdit();
            tip_zanyatiaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddForm1 af = new AddForm1();
            af.Owner = this;
            af.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.planzanyatiaBindingSource.EndEdit();
            this.plan_zanyatiaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void DataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

		private void CloseBtn_Click(object sender, EventArgs e)
		{
            Close();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            planzanyatiaBindingSource.EndEdit();
            plan_zanyatiaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

		



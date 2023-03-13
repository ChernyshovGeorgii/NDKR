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
	public partial class PostTov : Form
	{
		public PostTov()
		{
			InitializeComponent();
		}

		private void PostTov_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_sortirovki_i_rasfasovki". При необходимости она может быть перемещена или удалена.
            this.statys_sortirovki_i_rasfasovkiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_sortirovki_i_rasfasovki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavka_tovara". При необходимости она может быть перемещена или удалена.
            this.postavka_tovaraTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavka_tovara);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddForm5 af = new AddForm5();
			af.Owner = this;
			af.Show();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void button4_Click(object sender, EventArgs e)
        {
			postavkatovaraBindingSource.EndEdit();
			postavka_tovaraTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {

			SearchForm3 af = new SearchForm3();
			af.Owner = this;
			af.Show();
		}
    }
}

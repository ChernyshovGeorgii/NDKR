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
	public partial class Sotrudnik : Form
	{
		public Sotrudnik()
		{
			InitializeComponent();
		}

		private void Sotrudnik_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Dolzhnost". При необходимости она может быть перемещена или удалена.
            this.dolzhnostTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Dolzhnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kvalifikacia". При необходимости она может быть перемещена или удалена.
            this.kvalifikaciaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kvalifikacia);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
			this.sotrudnikTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddForm3 af = new AddForm3();
			af.Owner = this;
			af.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Kval af = new Kval();
			af.Owner = this;
			af.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SearchForm2 sf = new SearchForm2();
			sf.Owner = this;
			sf.Show();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void button4_Click(object sender, EventArgs e)
        {
			sotrudnikBindingSource.EndEdit();
			sotrudnikTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
			kvalifikaciaBindingSource.EndEdit();
			kvalifikaciaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }
    }
}

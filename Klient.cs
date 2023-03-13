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
	public partial class Klient : Form
	{
		public Klient()
		{
			InitializeComponent();
		}

		private void Klient_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Pol". При необходимости она может быть перемещена или удалена.
			this.polTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Pol);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient". При необходимости она может быть перемещена или удалена.
			this.klientTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddForm2 af = new AddForm2();
			af.Owner = this;
			af.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Pol af = new Pol();
			af.Owner = this;
			af.Show();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void button4_Click(object sender, EventArgs e)
        {
			klientBindingSource.EndEdit();
			klientTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
			polBindingSource.EndEdit();
			polTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {


			SearchForm5 af = new SearchForm5();
			af.Owner = this;
			af.Show();
		}
    }
}

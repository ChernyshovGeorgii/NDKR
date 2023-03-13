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
	public partial class Postavshik : Form
	{
		public Postavshik()
		{
			InitializeComponent();
		}

		private void Postavshik_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
			this.postavshikTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavshik);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddForm4 af = new AddForm4();
			af.Owner = this;
			af.Show();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void button4_Click(object sender, EventArgs e)
        {
			postavshikBindingSource.EndEdit();
			postavshikTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {

			SearchForm4 af = new SearchForm4();
			af.Owner = this;
			af.Show();
		}
    }
}

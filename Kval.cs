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
	public partial class Kval : Form
	{
		public Kval()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			Sotrudnik main = this.Owner as Sotrudnik;
			if (main != null)
			{
				DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[3].NewRow();
				int rc = main.dataGridView2.RowCount + 0;
				nRow[0] = rc;
				nRow[1] = tbKv.Text;
				main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[3].Rows.Add(nRow);
				main.kvalifikaciaTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kvalifikacia);
				main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[3].AcceptChanges();
				main.dataGridView1.Refresh();
				tbKv.Text = "";
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}

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
	public partial class Pol : Form
	{
		public Pol()
		{
			InitializeComponent();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
            Klient main = this.Owner as Klient;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[6].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbPol.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[6].Rows.Add(nRow);
                main.polTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Pol);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[6].AcceptChanges();
                main.dataGridView1.Refresh();
                tbPol.Text = "";
            }
        }
	}
}

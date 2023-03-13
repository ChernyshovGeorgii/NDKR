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
	public partial class AddForm3 : Form
	{
		public AddForm3()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
            Sotrudnik main = this.Owner as Sotrudnik;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[10].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbFam.Text;
                nRow[2] = tbName.Text;
                nRow[3] = tbOtch.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[10].Rows.Add(nRow);
                main.sotrudnikTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Sotrudnik);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[10].AcceptChanges();
                main.dataGridView1.Refresh();
                tbFam.Text = "";
                tbName.Text = "";
                tbOtch.Text = "";
            }
        }

		private void CloseBtn_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}

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
	public partial class AddForm4 : Form
	{
		public AddForm4()
		{
			InitializeComponent();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
            Postavshik main = this.Owner as Postavshik;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbFam.Text;
                nRow[2] = tbName.Text;
                nRow[3] = tbOtch.Text;
                nRow[4] = tbNaz.Text;
                nRow[5] = tbPhone.Text;
                nRow[6] = tbAdr.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[8].Rows.Add(nRow);
                main.postavshikTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavshik);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                tbFam.Text = "";
                tbName.Text = "";
                tbOtch.Text = "";
                tbNaz.Text = "";
                tbPhone.Text = "";
                tbAdr.Text = "";
            }
        }
	}
}

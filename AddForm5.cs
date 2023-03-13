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
	public partial class AddForm5 : Form
	{
		public AddForm5()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
            PostTov main = this.Owner as PostTov;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbPost.Text;
                nRow[2] = tbNmb.Text;
                nRow[3] = tbKol.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[7].Rows.Add(nRow);
                main.postavka_tovaraTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Postavka_tovara);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                tbPost.Text = "";
                tbNmb.Text = "";
                tbKol.Text = "";
            }
        }

		private void CloseBtn_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}

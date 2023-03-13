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
    public partial class AddForm1 : Form
    {
        public AddForm1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrgZan main = this.Owner as OrgZan;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbPlan.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[5].Rows.Add(nRow);
                main.organizatsya_zanyatiiTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Organizatsya_zanyatii);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                tbPlan.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


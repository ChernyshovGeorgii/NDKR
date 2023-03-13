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
    public partial class AddForm6 : Form
    {
        public AddForm6()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PrAb main = this.Owner as PrAb;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[9].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbDataZ.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[9].Rows.Add(nRow);
                main.prodazha_abonementaTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Prodazha_abonementa);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[9].AcceptChanges();
                main.dataGridView1.Refresh();
                tbDataZ.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

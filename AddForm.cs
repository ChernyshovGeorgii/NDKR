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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet1.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet1.Klient);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrgZan main = this.Owner as OrgZan;
            if (main != null)
            {
                DataRow nRow = main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[4].NewRow();
                int rc = main.dataGridView6.RowCount + 3;
                nRow[0] = rc;
                nRow[1] = tbVrIDt.Text;
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[4].Rows.Add(nRow);
                main.organizatsya_zanyatiiTableAdapter.Update(main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Organizatsya_zanyatii);
                main._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tables[4].AcceptChanges();
                main.dataGridView6.Refresh();
                tbVrIDt.Text = "";
              
            }
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}

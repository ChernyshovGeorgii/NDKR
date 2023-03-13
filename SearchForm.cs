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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OrgZan main = this.Owner as OrgZan;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView6.RowCount; i++)
                {
                    main.dataGridView6.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView6.ColumnCount; j++)
                        if (main.dataGridView6.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView6.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView6.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

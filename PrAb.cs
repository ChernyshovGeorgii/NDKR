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
    public partial class PrAb : Form
    {
        public PrAb()
        {
            InitializeComponent();
        }

        private void PrAb_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati". При необходимости она может быть перемещена или удалена.
            this.statys_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Srok_deystvia". При необходимости она может быть перемещена или удалена.
            this.srok_deystviaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Srok_deystvia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kategorya_abonementa". При необходимости она может быть перемещена или удалена.
            this.kategorya_abonementaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kategorya_abonementa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati". При необходимости она может быть перемещена или удалена.
            this.tip_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Tip_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati". При необходимости она может быть перемещена или удалена.
            this.statys_oplatiTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Statys_oplati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Srok_deystvia". При необходимости она может быть перемещена или удалена.
            this.srok_deystviaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Srok_deystvia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kategorya_abonementa". При необходимости она может быть перемещена или удалена.
            this.kategorya_abonementaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Kategorya_abonementa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_Фитнес_клуба_Athlete_FitnessDataSet.Prodazha_abonementa". При необходимости она может быть перемещена или удалена.
            this.prodazha_abonementaTableAdapter.Fill(this._ИС_Фитнес_клуба_Athlete_FitnessDataSet.Prodazha_abonementa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm6 af = new AddForm6();
            af.Owner = this;
            af.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prodazhaabonementaBindingSource.EndEdit();
            prodazha_abonementaTableAdapter.Update(_ИС_Фитнес_клуба_Athlete_FitnessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm1 sf = new SearchForm1();
            sf.Owner = this;
            sf.Show();
        }
    }
}

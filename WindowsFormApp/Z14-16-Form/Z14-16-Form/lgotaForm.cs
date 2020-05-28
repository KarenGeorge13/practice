using System;
using System.Windows.Forms;

namespace Z14_16_Form
{
    public partial class LgotaForm : Form
    {
        public LgotaForm()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            dataGridView1.Columns[0].HeaderText = "Код льготы";
            dataGridView1.Columns[1].HeaderText = "Тип льготы";
            dataGridView1.Columns[2].HeaderText = "Скидка";
        }
        private void lgotaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Lgota". При необходимости она может быть перемещена или удалена.
            this.lgotaTableAdapter.Fill(this.hostelDataSet.Lgota);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lgotaTableAdapter.Update(hostelDataSet);
        }
    }
}

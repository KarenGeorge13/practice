using System;
using System.Windows.Forms;

namespace Z14_16_Form
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            init();
        }
        void init() 
        {
            dataGridView1.Columns[0].HeaderText = "Номер комнаты";
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].HeaderText = "Стоимость";
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].HeaderText = "Вместимость";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Инструменты";
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].HeaderText = "Этаж";
        }
        private void roomsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomsTableAdapter.Update(hostelDataSet);
        }
    }
}

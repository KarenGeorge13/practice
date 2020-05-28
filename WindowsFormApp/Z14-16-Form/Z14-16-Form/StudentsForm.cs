using System;
using System.Windows.Forms;

namespace Z14_16_Form
{
	public partial class StudentsForm : Form
	{
		public StudentsForm()
		{
			InitializeComponent();
			init();
		}
		void init()
		{
			dataGridView1.Columns[0].HeaderText = "Код";
			dataGridView1.Columns[1].HeaderText = "ФИО";
			dataGridView1.Columns[2].HeaderText = "Год рождения";
			dataGridView1.Columns[3].HeaderText = "Пол";
			dataGridView1.Columns[4].HeaderText = "Адрес";
			dataGridView1.Columns[5].HeaderText = "Группа";
			dataGridView1.Columns[6].HeaderText = "Код льготы";
			dataGridView1.Columns[7].HeaderText = "№ паспорта";
			dataGridView1.Columns[8].HeaderText = "№ комнаты";
			dataGridView1.Columns[9].HeaderText = "Дата заселения";
		}
		private void studentsForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.hostelDataSet.Students);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			studentsTableAdapter.Update(hostelDataSet);
		}
	}
}

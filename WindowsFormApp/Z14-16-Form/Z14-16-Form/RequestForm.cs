using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Z14_16_Form
{
	public partial class RequestForm : Form
	{
		public RequestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\karli\\OneDrive\\Рабочий стол\\работы\\3 курс\\2 семестр\\практика\\DB1.mdb;");
			sqlconn.Open();
			string s = "";
			if (radioButton1.Checked) 
			{
				s = "SELECT * FROM Students";
			}
			if (radioButton2.Checked)
			{
				s = "SELECT SNP, Group, Address FROM Students";
			}
			if (radioButton3.Checked)
			{
				s = "SELECT DISTINCT Group FROM Students";
			}
			if (radioButton4.Checked)
			{
				s = "SELECT * FROM rooms where Flour = 3";
			}
			if (radioButton5.Checked)
			{
				s = "SELECT * FROM Students where Students.Group like 'ПО%'";
			}
			OleDbDataAdapter oda = new OleDbDataAdapter(s, sqlconn);
			DataTable dt = new DataTable();
			oda.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlconn.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewColumn col in dataGridView1.Columns) 
			{
				dataGridView1.Columns.Remove(col);
			}

		}
	}
}

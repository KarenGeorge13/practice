using System;
using System.Windows.Forms;

namespace Z14_16_Form
{
	public partial class ReportForm : Form
	{
		public ReportForm()
		{
			InitializeComponent();
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
			this.StudentsTableAdapter.Fill(this.hostelDataSet.Students);

			this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}

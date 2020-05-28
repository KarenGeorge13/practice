using System;
using System.Windows.Forms;

namespace Z14_16_Form
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsForm f = new RoomsForm();
            f.Show();
        }
        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm f = new StudentsForm();
            f.Show();
        }
        private void льготыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LgotaForm f = new LgotaForm();
            f.Show();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResettlementForm f = new ResettlementForm();
            f.Show();
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm f = new RequestForm();
            f.Show();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            f.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Z08_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string pattern = @"\d{2}:\d{2}:\d{2}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(s);
            foreach (Match match in matches)
            {
                string[] textDate = match.Value.Split(':');
                int hh = Convert.ToInt32(textDate[0]);
                int mm = Convert.ToInt32(textDate[1]);
                int ss = Convert.ToInt32(textDate[2]);
                if (hh >= 0 && hh < 24 && mm >= 0 && mm < 60 && ss >= 0 && ss < 60)
                {
                    if (ss >= 30)
                    {
                        mm++;
                    }
                    TimeSpan time = new TimeSpan(hh, mm, ss);
                    s = regex.Replace(s, time.ToString(@"hh\:mm"));
                }
            }
            textBox2.Text = s;
        }
    }
}

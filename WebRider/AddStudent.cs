using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebRider
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string student_id_text = s_id.Text;
            string student_name_text = s_name.Text;
            string student_phone_text = s_phone.Text;
            string student_case_text = s_casemanager.Text;
            string account_text = account_status.Text;
            string l_day = "";
            if (m.Checked)
                l_day += "M,";
            if (t.Checked)
                l_day += "T,";
            if (w.Checked)
                l_day += "W,";
            if (th.Checked)
                l_day += "Th,";
            if (f.Checked)
                l_day += "F,";
            if (s.Checked)
                l_day += "S,";
            Console.WriteLine(l_day);
        }
    }
}

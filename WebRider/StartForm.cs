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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administrator_Click(object sender, EventArgs e)
        {

        }

        private void student_login_Click(object sender, EventArgs e)
        {
            Attendance attendance_form = new Attendance();
            attendance_form.Show();
            attendance_form.WindowState = FormWindowState.Maximized;
        }
    }
}

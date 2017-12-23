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
        public string host_text = "localhost";
        public string port_text = "3306";
        public string db_user_text = "root";
        public string db_pass_text = "";
        public string db_name_text = "test";
        public StartForm()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administrator_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm(this);
            lf.Show();
            Console.WriteLine(this.db_name_text);
        }

        private void student_login_Click(object sender, EventArgs e)
        {
            Attendance attendance_form = new Attendance(this);
            attendance_form.Show();
            attendance_form.WindowState = FormWindowState.Maximized;
        }
    }
}

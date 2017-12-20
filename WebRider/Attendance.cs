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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }
        private void load_attendance_form(object sender, EventArgs e)
        {
            current_time_label.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            current_time_label.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

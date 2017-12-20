using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WebRider
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admin_save_btn_Click(object sender, EventArgs e)
        {
            string admin_username = admin_user.Text;
            string admin_password = admin_pass.Text;
            string sql = "INSERT INTO admin_accounts (Username, Password) VALUE ('" + admin_username + "','" + admin_password + "');";
            Console.WriteLine(sql);
            string connectionString = "server=localhost;database=test;uid=root;";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader();
            cnn.Close();
        }

        private void ss_btn_Click(object sender, EventArgs e)
        {
            string host_text = host_input.Text;
            string port_text = port_input.Text;
            string db_user_text = db_user_input.Text;
            string db_pass_text = db_pass_input.Text;
            string db_name_text = db_name_input.Text;
        }

        private void ts_btn_Click(object sender, EventArgs e)
        {
            string host_text = host_input.Text;
            string port_text = port_input.Text;
            string db_user_text = db_user_input.Text;
            string db_pass_text = db_pass_input.Text;
            string db_name_text = db_name_input.Text;
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Successful");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
            Console.WriteLine(thisday.ToString("d"));
            string student_name_text = student_name_input.Text;
            string student_phone_text = student_phone_input.Text;
            string student_case_text = student_case_input.Text;
            string account_text = account_combo.Text;
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
            
        }

        private void add_ns_btn_Click(object sender, EventArgs e)
        {
            AddStudent ans = new AddStudent();
            ans.Show();
        }
    }
}

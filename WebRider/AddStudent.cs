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
    public partial class AddStudent : Form
    {
        string host_text = "localhost";
        string port_text = "3306";
        string db_user_text = "root";
        string db_pass_text = "";
        string db_name_text = "test";
        string adminname = null;
        public AddStudent(string admin_name)
        {
            InitializeComponent();
            this.adminname = admin_name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime thisday = DateTime.Today;
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
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            string sql = "insert into students_accounts (Student_ID, Student_Name, Student_Phone, Student_Case_Manager, Account_Status, Student_Photo, Student_FingerPrints, Login_Days, Created_On, Created_By) value ('" +
                student_id_text + "','" + student_name_text + "','" + student_phone_text + "','" + student_case_text + "','" + account_text + "','" + "','" + "','"
                + l_day+ "','" + thisday.ToString("yyyyy-MM-dd") + "','" + this.adminname + "');";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader();
            cnn.Close();
            Console.WriteLine(sql);
        }
    }
}

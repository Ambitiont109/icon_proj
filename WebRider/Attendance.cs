using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WebRider
{
    public partial class Attendance : Form
    {
        public string host_text;
        public string port_text;
        public string db_user_text;
        public string db_pass_text;
        public string db_name_text;
        StartForm parent;
        public Attendance(StartForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            verificationUserControl.VerificationStatusChanged += new StatusChangedEventHandler(on_status_changed);
            ValidateUser();
            host_text = parent.host_text;
            port_text = parent.port_text;
            db_user_text = parent.db_user_text;
            db_pass_text = parent.db_pass_text;
            db_name_text = parent.db_name_text;

        }
        void ValidateUser()
        {
            string sql = "select Student_FingerPrints,Student_ID from students_accounts ";
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            try
            {
                cnn.Open();
                // MessageBox.Show("connection open!");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    if (reader["Student_FingerPrints"] != null)
                    {                        
                        byte[] fingerPrint = { 2,3,4,5};
                        //byte[] fingerPrint = (byte[])reader["Student_FingerPrints"];
                        String student_id = reader.GetString("Student_ID");
                        verificationUserControl.Samples.Add(new DPFP.Template(new MemoryStream(fingerPrint)), student_id);
                    }

                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't open connection!"+ex.ToString());
            }

        }
        private void load_attendance_form(object sender, EventArgs e)
        {
            current_time_label.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            current_time_label.Text = DateTime.Now.ToLongTimeString();
        }
        private void on_status_changed(object sender, StatusChangedEventArgs e)
        {
            if(e.Status == true)//Verified 
            {
                String student_id = (String)verificationUserControl.VerifiedObject;
                MessageBox.Show("Logged In");
                show_login_student_info(student_id);
            }
            //if(e.Status)
        }
        private void show_login_student_info(String student_id)
        {
            student_id = "2";
            string sql = "select * from students_accounts where Student_ID = "+student_id;
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            DateTime thisday = DateTime.Now;
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            try
            {
                cnn.Open();
                // MessageBox.Show("connection open!");
                MySqlDataReader reader = cmd.ExecuteReader();
                sql = "";
                while (reader.Read())
                {
                    String Student_Id = reader.GetString("Student_ID");
                    String student_name = reader.GetString("Student_Name");
                    String student_phone = reader.GetString("Student_Phone");
                    String Accound_Status = reader.GetString("Account_Status");
                    String Student_photo_path = reader.GetString("Student_Photo");
                    String student_case_manager = reader.GetString("Student_Case_Manager");
                    string path = Path.Combine(Environment.CurrentDirectory, @"Photos\", Student_photo_path);
                    pictureBox1.Image = new Bitmap(path);
                    textBox1.Text = Student_Id;
                    textBox2.Text = student_name;
                    textBox3.Text = student_phone;
                    textBox4.Text = Accound_Status;                 
                }
                cnn.Close();
                if(sql != "")
                {
                    cnn.Open();
                    cmd = new MySqlCommand(sql, cnn);
                    cmd.ExecuteReader();
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Loadin Database:\n" + ex.ToString());
            }
        }

        private void admin_link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm(parent);
            lf.Show();
        }
    }
}

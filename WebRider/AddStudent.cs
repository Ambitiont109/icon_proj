﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string student_cur_photo_path = "";
        byte[] FingerPrint;
        DPFP.Sample sample;
        public AddStudent(string admin_name)
        {
            InitializeComponent();
            this.adminname = admin_name;
            this.sample = null;
            string sql = "select max(Student_Id) from students_accounts";
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            int id = 0;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0] == DBNull.Value)
                    id = 1;
                else
                    id = reader.GetInt32(0) +1;
            }
            s_id.Text = id.ToString();
            cnn.Close();
        }
        private string MoveCopy(String source, String target)
        {
            // assuming that target directory exists
            String name = target;
            if (!File.Exists(target))
                File.Copy(source, target);
            else
                for (int i = 1; ; ++i)
                {
                      name = Path.Combine(
                      Path.GetDirectoryName(target),
                      Path.GetFileNameWithoutExtension(target) + String.Format("(copy{0})", i) +
                      Path.GetExtension(target));

                    if (!File.Exists(name))
                    {
                        File.Copy(source, name);

                        break;
                    }
                }
            return name;
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
            string photo_path = Path.Combine(Environment.CurrentDirectory, @"Photos\", Path.GetFileName(student_cur_photo_path));
            if(student_id_text==""|| student_name_text == "" || student_phone_text == "" || student_case_text == "" || account_text == "")
            {
                MessageBox.Show("You Must Input All the fields");
                return;
            }
            if (student_cur_photo_path == "")
            {
                MessageBox.Show("You Didn't Input your Photo");
                photo_path = "NONE";
                return;
            }
            else
            {
                photo_path = MoveCopy(student_cur_photo_path, photo_path);
                photo_path = Path.GetFileName(photo_path);
            }
            //byte[] temp = { 1, 2, 3, 1, 6 };
            //this.FingerPrint = temp;
            
            if(this.sample == null)
            {
                MessageBox.Show("Didn't Capture FingerPrint");
                return;
            }
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
                student_id_text + "','" + student_name_text + "','" + student_phone_text + "','" + student_case_text + "','" + account_text + "','" + photo_path + "'," +"@byteData"+ ",'"
                + l_day+ "','" + thisday.ToString("yyyy-MM-dd") + "','" + this.adminname + "');";

            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            cmd.Parameters.Add(new MySqlParameter("@byteData", this.FingerPrint));
            reader = cmd.ExecuteReader();
            cnn.Close();
            Console.WriteLine(sql);
            this.DialogResult = DialogResult.OK;
        }

        private void upload_photo_Click(object sender, EventArgs e)
        {           
               OpenFileDialog open = new OpenFileDialog();
               // image filters  
               open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
               if (open.ShowDialog() == DialogResult.OK)
               {
                   // display image in picture box  
                   pictureBox1.Image = new Bitmap(open.FileName);
                   student_cur_photo_path = open.FileName;
               }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Fingerprint_scan_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            if(reg.ShowDialog() == DialogResult.OK)
            {
                this.sample = reg.fingerPrintRegUserControl.showed_sample;
                this.FingerPrint = reg.fingerPrintRegUserControl.FingerPrint;
                DrawPicture(FingerPrintUtility.ConvertSampleToBitmap(this.sample));
            }
        }
        private void DrawPicture(Bitmap bitmap)
        {
            fingerpicture.Image = new Bitmap(bitmap, fingerpicture.Size); // fit the image into the picture box
        }
    }
}

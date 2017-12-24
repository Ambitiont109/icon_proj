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
using System.IO;
using DPFP;
using DPFP.Capture;

namespace WebRider
{
    public partial class AdminForm : Form, DPFP.Capture.EventHandler
    {
        string host_text;
        string port_text;
        string db_user_text;
        string db_pass_text;
        string db_name_text;
        string adminname = null;
        string photo_path = "";
        string prev_photo_path = "";
        byte[] fingerprint;
        StartForm parent;
        DPFP.Sample sample;
        DPFP.Capture.Capture Capturer;
        public AdminForm(string admin_name,StartForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.adminname = admin_name;
            host_text = parent.host_text;
            port_text = parent.port_text;
            db_user_text = parent.db_user_text;
            db_pass_text = parent.db_pass_text;
            db_name_text = parent.db_name_text;
            load_table();
            Capturer = new DPFP.Capture.Capture();
            Capturer.EventHandler = this;

        }

        public void load_table()
        {
            s_table.Rows.Clear();
            string sql = "select * from students_accounts ";
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            try
            {
                cnn.Open();
                // MessageBox.Show("connection open!");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //s_table.Columns.Add(chk);                    
                    s_table.Rows.Add(reader.GetInt32("Student_ID"), reader.GetString("Student_Name"), reader.GetString("Student_Phone"),
                        reader.GetString("Student_Case_Manager"), reader.GetString("Account_Status"), reader.GetString("Student_Photo"),
                        reader.GetString("Student_FingerPrints"), reader.GetString("Created_On").Split(' ')[0], reader.GetString("Login_Days"));
                    
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admin_save_btn_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            string admin_username = admin_user.Text;
            string admin_password = admin_pass.Text;
            string sql = "INSERT INTO admin_accounts (Username, Password) VALUE ('" + admin_username + "','" + admin_password + "');";
            Console.WriteLine(sql);
            connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader();
            cnn.Close();
        }

        private void ss_btn_Click(object sender, EventArgs e)
        {
            this.host_text = host_input.Text;
            this.port_text = port_input.Text;
            this.db_user_text = db_user_input.Text;
            this.db_pass_text = db_pass_input.Text;
            this.db_name_text = db_name_input.Text;
            parent.host_text = host_input.Text;
            parent.port_text = port_input.Text;
            parent.db_user_text = db_user_input.Text;
            parent.db_pass_text = db_pass_input.Text;
            parent.db_name_text = db_name_input.Text;

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
        private void save_btn_Click(object sender, EventArgs e)
        {
            int index = s_table.SelectedRows[0].Index;
            Console.WriteLine(s_table[0, index].Value.GetType());
            string value = s_table[0, index].Value.ToString();
            int id = Int32.Parse(value);
            DateTime thisday = DateTime.Today;
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
            if(this.prev_photo_path != this.photo_path)
            {
                string temp_photo_path = Path.Combine(Environment.CurrentDirectory, @"Photos\", Path.GetFileName(this.prev_photo_path));
                try
                {
                    File.Delete(temp_photo_path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.ToString());
                }
                temp_photo_path = Path.Combine(Environment.CurrentDirectory, @"Photos\", Path.GetFileName(photo_path));
                temp_photo_path = MoveCopy(this.photo_path, temp_photo_path);
                
                this.photo_path = Path.GetFileName(temp_photo_path);
            }
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            string sql = "update students_accounts set Student_Name='" + student_name_text + "',Student_Phone='" + student_phone_text + "',Student_Case_Manager='" +
                student_case_text + "',Account_Status='" + account_text + "',Login_Days='" + l_day + "',Student_Photo='"+this.photo_path+ "',Student_FingerPrints = @byteData" + " where Student_ID = " + id+"; ";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            cmd.Parameters.Add(new MySqlParameter("@byteData", this.fingerprint));
            reader = cmd.ExecuteReader();
            cnn.Close();
            
            Console.WriteLine(sql);
            load_table();
        }

        private void add_ns_btn_Click(object sender, EventArgs e)
        {
            AddStudent ans = new AddStudent(this.adminname);
            if(ans.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Add Student Successfully");
                load_table();
            }
        }

        private void del_s_btn_Click(object sender, EventArgs e)
        {
            if (s_table.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You Didn't Select Student\n");
                return;
            }
                
            int index = s_table.SelectedRows[0].Index;
            Console.WriteLine(s_table[0, index].Value.GetType());
            string value = s_table[0, index].Value.ToString();
            int id = Int32.Parse(value);
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            string sql = "delete from students_accounts where Student_ID=" + id+";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader reader;
            cnn.Open();
            reader = cmd.ExecuteReader();
            cnn.Close();
            Console.WriteLine(sql);
            load_table();
        }

        private void edit_s_btn_Click(object sender, EventArgs e)
        {
            if (s_table.SelectedRows.Count <= 0)
                return;
            int index = s_table.SelectedRows[0].Index;
            string value = s_table[0, index].Value.ToString();
            int id = Int32.Parse(value);
            student_name_input.Text = s_table[1, index].Value.ToString();
            student_phone_input.Text = s_table[2, index].Value.ToString();
            student_case_input.Text = s_table[3, index].Value.ToString();
            account_combo.Text = s_table[4, index].Value.ToString();
            string[] data = s_table[8, index].Value.ToString().Split(',');
            Console.WriteLine(s_table[8,index].Value.ToString());
            for (int i = 0; i < data.Length-1; i++)
            {
                Console.WriteLine(data[i]);
                if (data[i] == "M")
                    m.Checked = true;
                if (data[i] == "T")
                    t.Checked = true;
                if (data[i] == "W")
                    w.Checked = true;
                if (data[i] == "Th")
                    th.Checked = true;
                if (data[i] == "F")
                    f.Checked = true;
                if (data[i] == "S")
                    s.Checked = true;
            }
            string sql = "select Student_FingerPrints,Student_Photo from students_accounts where Student_ID = '" + id.ToString()+"'";
            string connectionString = "server=" + host_text + ";port=" + port_text + ";database=" + db_name_text + ";uid=" + db_user_text + ";pwd=" + db_pass_text + ";";
            string photo_path="";
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
                        this.fingerprint = (byte[])reader["Student_FingerPrints"];                        
                    }
                    this.photo_path = reader.GetString("Student_Photo");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't open connection!" + ex.ToString());
            }
            //this.photo_picture_box = photo_path;
            photo_path = Path.Combine(Environment.CurrentDirectory, @"Photos\", this.photo_path);
            this.photo_picture_box.Image = new Bitmap(photo_path);
            this.prev_photo_path = this.photo_path;
        }

        private void upload_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                photo_picture_box.Image.Dispose();
                this.photo_picture_box.Image = new Bitmap(open.FileName);             

                this.photo_path = open.FileName;
            }
        }

        private void Fingerprint_scan_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            if (reg.ShowDialog() == DialogResult.OK)
            {
                this.sample = reg.fingerPrintRegUserControl.showed_sample;
                this.fingerprint = reg.fingerPrintRegUserControl.FingerPrint;
                DrawPicture(FingerPrintUtility.ConvertSampleToBitmap(this.sample));
            }
        }
        private void DrawPicture(Bitmap bitmap)
        {
            fingerprint_picture_box.Image = new Bitmap(bitmap, fingerprint_picture_box.Size); // fit the image into the picture box
        }

        private void detects_btn_Click(object sender, EventArgs e)
        {
           Capturer.StartCapture();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            throw new NotImplementedException();
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            throw new NotImplementedException();
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            throw new NotImplementedException();
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            this.label12.Text = "Connected";
            this.label12.ForeColor = Color.Green;
            Capturer.StopCapture();            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            //this.label12.Visible = false;
            this.label12.Text = "Disconnected";
            this.label12.ForeColor = Color.Red;
            //this.label13.Visible = true;

            Capturer.StopCapture();
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WebRider
{
    public partial class LoginForm : Form
    {
        StartForm parent;
        public LoginForm(StartForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            List<int> i_list = new List<int>();
            List<string> u_list = new List<string>();
            List<string> p_list = new List<string>();
            string sql = "select * from admin_accounts ";
            string connectionString = "server=" + parent.host_text + ";port=" + parent.port_text + ";database=" + parent.db_name_text + ";uid=" + parent.db_user_text + ";pwd=" + parent.db_pass_text + ";";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            try
            {
                cnn.Open();
                // MessageBox.Show("connection open!");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i_list.Add(reader.GetInt32("ID"));
                    u_list.Add(reader.GetString("Username"));
                    p_list.Add(reader.GetString("Password"));
                }
                for(int i = 0; i < u_list.Count; i++)
                {
                    if (u_list.ElementAt(i) == username_input.Text)
                        if (p_list.ElementAt(i) == password_input.Text)
                        {
                            AdminForm af = new AdminForm(username_input.Text,parent);
                            af.Show();
                        }
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't open connection!");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
        }
    }
}

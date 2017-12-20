using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WebRider
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            ValidateUser();
        }
        void ValidateUser()
        {
            byte[] fingerPrint = { 2, 4, 5 };
            verificationUserControl.Samples.Add(new DPFP.Template(new MemoryStream(fingerPrint)), null);
            /*            using (SqlConnection con = new SqlConnection(Helper.GetConnection()))
                        {
                            con.Open();
                            string query = @"SELECT UserID, Thumb FROM Users";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                using (SqlDataReader data = cmd.ExecuteReader())
                                {

                                    while (data.Read())
                                    {
                                        byte[] fingerPrint = (byte[])data["Thumb"];
                                        verificationUserControl.Samples.Add(new DPFP.Template(new MemoryStream(fingerPrint)), null);
                                    }
                                }
                            }
                        }*/
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

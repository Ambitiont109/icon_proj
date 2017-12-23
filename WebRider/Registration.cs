using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebRider
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.fingerPrintRegUserControl.RegistrationCompletedStatusChanged += new StatusChangedEventHandler(fingerPrintRegUserControl_RegistrationCompleted);
        }

        private void fingerPrintRegUserControl_RegistrationCompleted(object sender, StatusChangedEventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (this.fingerPrintRegUserControl.IsRegistrationComplete == false)
            {
                MessageBox.Show("Didn't Capture Fingerprint yet");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

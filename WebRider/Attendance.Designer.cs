namespace WebRider
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.current_time_label = new System.Windows.Forms.Label();
            this.admin_link_label = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.verificationUserControl = new WebRider.VerificationUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Finger Print";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // current_time_label
            // 
            this.current_time_label.AutoSize = true;
            this.current_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_time_label.Location = new System.Drawing.Point(271, 77);
            this.current_time_label.Name = "current_time_label";
            this.current_time_label.Size = new System.Drawing.Size(104, 20);
            this.current_time_label.TabIndex = 2;
            this.current_time_label.Text = " Current Time";
            // 
            // admin_link_label
            // 
            this.admin_link_label.AutoSize = true;
            this.admin_link_label.Location = new System.Drawing.Point(442, 36);
            this.admin_link_label.Name = "admin_link_label";
            this.admin_link_label.Size = new System.Drawing.Size(36, 13);
            this.admin_link_label.TabIndex = 3;
            this.admin_link_label.TabStop = true;
            this.admin_link_label.Text = "Admin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student_Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Phone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 375);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(147, 421);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 142);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // visualStyler1
            // 
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Office2007 (Blue).vssf");
            // 
            // verificationUserControl
            // 
            this.verificationUserControl.IsVerificationComplete = false;
            this.verificationUserControl.Location = new System.Drawing.Point(39, 66);
            this.verificationUserControl.Name = "verificationUserControl";
            this.verificationUserControl.Size = new System.Drawing.Size(157, 177);
            this.verificationUserControl.TabIndex = 6;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 580);
            this.Controls.Add(this.verificationUserControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.admin_link_label);
            this.Controls.Add(this.current_time_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.load_attendance_form);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label current_time_label;
        private System.Windows.Forms.LinkLabel admin_link_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private VerificationUserControl verificationUserControl;
    }
}
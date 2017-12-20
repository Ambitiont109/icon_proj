namespace WebRider
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.TextBox();
            this.s_name = new System.Windows.Forms.TextBox();
            this.s_phone = new System.Windows.Forms.TextBox();
            this.s_casemanager = new System.Windows.Forms.TextBox();
            this.account_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.CheckBox();
            this.t = new System.Windows.Forms.CheckBox();
            this.w = new System.Windows.Forms.CheckBox();
            this.th = new System.Windows.Forms.CheckBox();
            this.f = new System.Windows.Forms.CheckBox();
            this.s = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Case Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Status";
            // 
            // s_id
            // 
            this.s_id.Location = new System.Drawing.Point(172, 18);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(133, 20);
            this.s_id.TabIndex = 5;
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(172, 43);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(133, 20);
            this.s_name.TabIndex = 6;
            // 
            // s_phone
            // 
            this.s_phone.Location = new System.Drawing.Point(172, 70);
            this.s_phone.Name = "s_phone";
            this.s_phone.Size = new System.Drawing.Size(133, 20);
            this.s_phone.TabIndex = 7;
            // 
            // s_casemanager
            // 
            this.s_casemanager.Location = new System.Drawing.Point(172, 97);
            this.s_casemanager.Name = "s_casemanager";
            this.s_casemanager.Size = new System.Drawing.Size(133, 20);
            this.s_casemanager.TabIndex = 8;
            // 
            // account_status
            // 
            this.account_status.FormattingEnabled = true;
            this.account_status.Items.AddRange(new object[] {
            "Active",
            "Disable"});
            this.account_status.Location = new System.Drawing.Point(172, 126);
            this.account_status.Name = "account_status";
            this.account_status.Size = new System.Drawing.Size(121, 21);
            this.account_status.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Photo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Student Finger Print";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(87, 546);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(207, 546);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 15;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(29, 480);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(64, 17);
            this.m.TabIndex = 16;
            this.m.Text = "Monday";
            this.m.UseVisualStyleBackColor = true;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(29, 503);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(67, 17);
            this.t.TabIndex = 17;
            this.t.Text = "Tuesday";
            this.t.UseVisualStyleBackColor = true;
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(132, 480);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(83, 17);
            this.w.TabIndex = 18;
            this.w.Text = "Wednesday";
            this.w.UseVisualStyleBackColor = true;
            // 
            // th
            // 
            this.th.AutoSize = true;
            this.th.Location = new System.Drawing.Point(132, 503);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(70, 17);
            this.th.TabIndex = 19;
            this.th.Text = "Thursday";
            this.th.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(251, 480);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(54, 17);
            this.f.TabIndex = 20;
            this.f.Text = "Friday";
            this.f.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(251, 503);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(68, 17);
            this.s.TabIndex = 21;
            this.s.Text = "Saturday";
            this.s.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 581);
            this.Controls.Add(this.s);
            this.Controls.Add(this.f);
            this.Controls.Add(this.th);
            this.Controls.Add(this.w);
            this.Controls.Add(this.t);
            this.Controls.Add(this.m);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.account_status);
            this.Controls.Add(this.s_casemanager);
            this.Controls.Add(this.s_phone);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox s_phone;
        private System.Windows.Forms.TextBox s_casemanager;
        private System.Windows.Forms.ComboBox account_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox m;
        private System.Windows.Forms.CheckBox t;
        private System.Windows.Forms.CheckBox w;
        private System.Windows.Forms.CheckBox th;
        private System.Windows.Forms.CheckBox f;
        private System.Windows.Forms.CheckBox s;
    }
}
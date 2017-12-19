namespace WebRider
{
    partial class AdminForm
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
            this.admin_form = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_s_btn = new System.Windows.Forms.Button();
            this.del_s_btn = new System.Windows.Forms.Button();
            this.add_ns_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.student_name_input = new System.Windows.Forms.TextBox();
            this.student_phone_input = new System.Windows.Forms.TextBox();
            this.student_case_input = new System.Windows.Forms.TextBox();
            this.account_combo = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel1_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.admin_form.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_form
            // 
            this.admin_form.Controls.Add(this.tabPage1);
            this.admin_form.Controls.Add(this.tabPage2);
            this.admin_form.Controls.Add(this.tabPage3);
            this.admin_form.Controls.Add(this.tabPage4);
            this.admin_form.Location = new System.Drawing.Point(56, 22);
            this.admin_form.Name = "admin_form";
            this.admin_form.SelectedIndex = 0;
            this.admin_form.Size = new System.Drawing.Size(1213, 585);
            this.admin_form.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cancel1_btn);
            this.tabPage1.Controls.Add(this.save_btn);
            this.tabPage1.Controls.Add(this.account_combo);
            this.tabPage1.Controls.Add(this.student_case_input);
            this.tabPage1.Controls.Add(this.student_phone_input);
            this.tabPage1.Controls.Add(this.student_name_input);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edit_s_btn);
            this.tabPage1.Controls.Add(this.del_s_btn);
            this.tabPage1.Controls.Add(this.add_ns_btn);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1205, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Case Manager";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Name";
            // 
            // edit_s_btn
            // 
            this.edit_s_btn.Location = new System.Drawing.Point(410, 287);
            this.edit_s_btn.Name = "edit_s_btn";
            this.edit_s_btn.Size = new System.Drawing.Size(109, 23);
            this.edit_s_btn.TabIndex = 3;
            this.edit_s_btn.Text = "Edit Selected";
            this.edit_s_btn.UseVisualStyleBackColor = true;
            // 
            // del_s_btn
            // 
            this.del_s_btn.Location = new System.Drawing.Point(250, 287);
            this.del_s_btn.Name = "del_s_btn";
            this.del_s_btn.Size = new System.Drawing.Size(138, 23);
            this.del_s_btn.TabIndex = 2;
            this.del_s_btn.Text = "Delete Selected";
            this.del_s_btn.UseVisualStyleBackColor = true;
            // 
            // add_ns_btn
            // 
            this.add_ns_btn.Location = new System.Drawing.Point(102, 287);
            this.add_ns_btn.Name = "add_ns_btn";
            this.add_ns_btn.Size = new System.Drawing.Size(128, 23);
            this.add_ns_btn.TabIndex = 1;
            this.add_ns_btn.Text = "Add New Student";
            this.add_ns_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1205, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1205, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detect Scanner";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1205, 559);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Admin Account";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account Status";
            // 
            // student_name_input
            // 
            this.student_name_input.Location = new System.Drawing.Point(224, 355);
            this.student_name_input.Name = "student_name_input";
            this.student_name_input.Size = new System.Drawing.Size(164, 20);
            this.student_name_input.TabIndex = 8;
            // 
            // student_phone_input
            // 
            this.student_phone_input.Location = new System.Drawing.Point(224, 382);
            this.student_phone_input.Name = "student_phone_input";
            this.student_phone_input.Size = new System.Drawing.Size(164, 20);
            this.student_phone_input.TabIndex = 9;
            // 
            // student_case_input
            // 
            this.student_case_input.Location = new System.Drawing.Point(224, 409);
            this.student_case_input.Name = "student_case_input";
            this.student_case_input.Size = new System.Drawing.Size(164, 20);
            this.student_case_input.TabIndex = 10;
            // 
            // account_combo
            // 
            this.account_combo.FormattingEnabled = true;
            this.account_combo.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.account_combo.Location = new System.Drawing.Point(224, 438);
            this.account_combo.Name = "account_combo";
            this.account_combo.Size = new System.Drawing.Size(113, 21);
            this.account_combo.TabIndex = 12;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(155, 499);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // cancel1_btn
            // 
            this.cancel1_btn.Location = new System.Drawing.Point(262, 499);
            this.cancel1_btn.Name = "cancel1_btn";
            this.cancel1_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel1_btn.TabIndex = 14;
            this.cancel1_btn.Text = "Cancel";
            this.cancel1_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Student Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Student FingerPrint";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 627);
            this.Controls.Add(this.admin_form);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.admin_form.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admin_form;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_s_btn;
        private System.Windows.Forms.Button del_s_btn;
        private System.Windows.Forms.Button add_ns_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox account_combo;
        private System.Windows.Forms.TextBox student_case_input;
        private System.Windows.Forms.TextBox student_phone_input;
        private System.Windows.Forms.TextBox student_name_input;
        private System.Windows.Forms.Button cancel1_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
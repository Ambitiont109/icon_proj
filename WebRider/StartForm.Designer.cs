namespace WebRider
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.student_login = new System.Windows.Forms.Button();
            this.administrator = new System.Windows.Forms.Button();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_login
            // 
            this.student_login.Location = new System.Drawing.Point(24, 28);
            this.student_login.Name = "student_login";
            this.student_login.Size = new System.Drawing.Size(156, 47);
            this.student_login.TabIndex = 0;
            this.student_login.Text = "Student Login";
            this.student_login.UseVisualStyleBackColor = true;
            this.student_login.Click += new System.EventHandler(this.student_login_Click);
            // 
            // administrator
            // 
            this.administrator.Location = new System.Drawing.Point(186, 28);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(156, 47);
            this.administrator.TabIndex = 0;
            this.administrator.Text = "Administrator";
            this.administrator.UseVisualStyleBackColor = true;
            this.administrator.Click += new System.EventHandler(this.administrator_Click);
            // 
            // visualStyler1
            // 
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Office2007 (Blue).vssf");
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 93);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.student_login);
            this.Name = "StartForm";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button student_login;
        private System.Windows.Forms.Button administrator;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
    }
}


namespace WebRider
{
    partial class VerificationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prompt = new System.Windows.Forms.Label();
            this.FingerPrintPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FingerPrintPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Location = new System.Drawing.Point(6, 156);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(37, 13);
            this.Prompt.TabIndex = 21;
            this.Prompt.Text = "Status";
            // 
            // FingerPrintPicture
            // 
            this.FingerPrintPicture.BackColor = System.Drawing.SystemColors.Window;
            this.FingerPrintPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FingerPrintPicture.Location = new System.Drawing.Point(9, 7);
            this.FingerPrintPicture.Name = "FingerPrintPicture";
            this.FingerPrintPicture.Size = new System.Drawing.Size(129, 125);
            this.FingerPrintPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FingerPrintPicture.TabIndex = 20;
            this.FingerPrintPicture.TabStop = false;
            // 
            // VerificationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.FingerPrintPicture);
            this.Name = "VerificationUserControl";
            this.Size = new System.Drawing.Size(157, 177);
            ((System.ComponentModel.ISupportInitialize)(this.FingerPrintPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.PictureBox FingerPrintPicture;
    }
}

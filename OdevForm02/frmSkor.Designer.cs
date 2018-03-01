namespace OdevForm02
{
    partial class frmSkor
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
            this.Skortxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Skortxt
            // 
            this.Skortxt.Location = new System.Drawing.Point(119, 76);
            this.Skortxt.Multiline = true;
            this.Skortxt.Name = "Skortxt";
            this.Skortxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Skortxt.Size = new System.Drawing.Size(221, 189);
            this.Skortxt.TabIndex = 0;
            // 
            // frmSkor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 363);
            this.Controls.Add(this.Skortxt);
            this.Name = "frmSkor";
            this.Text = "frmSkor";
            this.Load += new System.EventHandler(this.frmSkor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Skortxt;
    }
}
namespace OdevForm02
{
    partial class frmOyun
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
            this.btnyakala = new System.Windows.Forms.Button();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbloyuncu = new System.Windows.Forms.Label();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnyakala
            // 
            this.btnyakala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyakala.Location = new System.Drawing.Point(148, 89);
            this.btnyakala.Margin = new System.Windows.Forms.Padding(2);
            this.btnyakala.Name = "btnyakala";
            this.btnyakala.Size = new System.Drawing.Size(139, 64);
            this.btnyakala.TabIndex = 0;
            this.btnyakala.Text = "YAKALA !!!";
            this.btnyakala.UseVisualStyleBackColor = true;
            this.btnyakala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnyakala_MouseMove);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(12, 136);
            this.lblsure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(46, 17);
            this.lblsure.TabIndex = 1;
            this.lblsure.Text = "label1";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(12, 183);
            this.lblpuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(46, 17);
            this.lblpuan.TabIndex = 2;
            this.lblpuan.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbloyuncu
            // 
            this.lbloyuncu.AutoSize = true;
            this.lbloyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbloyuncu.Location = new System.Drawing.Point(12, 63);
            this.lbloyuncu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloyuncu.Name = "lbloyuncu";
            this.lbloyuncu.Size = new System.Drawing.Size(46, 17);
            this.lbloyuncu.TabIndex = 3;
            this.lbloyuncu.Text = "label1";
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlBilgi.Controls.Add(this.lbloyuncu);
            this.pnlBilgi.Controls.Add(this.lblsure);
            this.pnlBilgi.Controls.Add(this.lblpuan);
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBilgi.Location = new System.Drawing.Point(501, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(102, 448);
            this.pnlBilgi.TabIndex = 4;
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 448);
            this.Controls.Add(this.pnlBilgi);
            this.Controls.Add(this.btnyakala);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOyun";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOyun_FormClosed);
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyakala;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbloyuncu;
        private System.Windows.Forms.Panel pnlBilgi;
    }
}


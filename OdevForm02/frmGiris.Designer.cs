namespace OdevForm02
{
    partial class frmGiris
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
            this.btnbaslat = new System.Windows.Forms.Button();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdZor = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.rdKolay = new System.Windows.Forms.RadioButton();
            this.grpOyuncu = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.Skorbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpOyuncu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbaslat
            // 
            this.btnbaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbaslat.Location = new System.Drawing.Point(75, 289);
            this.btnbaslat.Margin = new System.Windows.Forms.Padding(2);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(99, 32);
            this.btnbaslat.TabIndex = 0;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Location = new System.Drawing.Point(79, 20);
            this.lblbaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(95, 20);
            this.lblbaslik.TabIndex = 1;
            this.lblbaslik.Text = "Hoşgeldiniz!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdZor);
            this.groupBox1.Controls.Add(this.rdOrta);
            this.groupBox1.Controls.Add(this.rdKolay);
            this.groupBox1.Location = new System.Drawing.Point(19, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zorluk Seviyesi";
            // 
            // rdZor
            // 
            this.rdZor.AutoSize = true;
            this.rdZor.Location = new System.Drawing.Point(143, 30);
            this.rdZor.Name = "rdZor";
            this.rdZor.Size = new System.Drawing.Size(41, 17);
            this.rdZor.TabIndex = 11;
            this.rdZor.TabStop = true;
            this.rdZor.Text = "Zor";
            this.rdZor.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(92, 30);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(45, 17);
            this.rdOrta.TabIndex = 10;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // rdKolay
            // 
            this.rdKolay.AutoSize = true;
            this.rdKolay.Location = new System.Drawing.Point(35, 30);
            this.rdKolay.Name = "rdKolay";
            this.rdKolay.Size = new System.Drawing.Size(51, 17);
            this.rdKolay.TabIndex = 9;
            this.rdKolay.TabStop = true;
            this.rdKolay.Text = "Kolay";
            this.rdKolay.UseVisualStyleBackColor = true;
            // 
            // grpOyuncu
            // 
            this.grpOyuncu.Controls.Add(this.txtad);
            this.grpOyuncu.Controls.Add(this.lblsoyad);
            this.grpOyuncu.Controls.Add(this.txtsoyad);
            this.grpOyuncu.Controls.Add(this.lblad);
            this.grpOyuncu.Location = new System.Drawing.Point(19, 61);
            this.grpOyuncu.Name = "grpOyuncu";
            this.grpOyuncu.Size = new System.Drawing.Size(217, 115);
            this.grpOyuncu.TabIndex = 10;
            this.grpOyuncu.TabStop = false;
            this.grpOyuncu.Text = "Oyuncu Bilgileri";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(90, 31);
            this.txtad.Margin = new System.Windows.Forms.Padding(2);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 24);
            this.txtad.TabIndex = 7;
            this.txtad.Tag = "Adınızı";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblsoyad.Location = new System.Drawing.Point(11, 66);
            this.lblsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(60, 15);
            this.lblsoyad.TabIndex = 8;
            this.lblsoyad.Text = "Soyadınız";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(90, 65);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 24);
            this.txtsoyad.TabIndex = 9;
            this.txtsoyad.Tag = "Soyadınızı";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblad.Location = new System.Drawing.Point(11, 32);
            this.lblad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(40, 15);
            this.lblad.TabIndex = 6;
            this.lblad.Text = "Adınız";
            // 
            // Skorbtn
            // 
            this.Skorbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skorbtn.Location = new System.Drawing.Point(271, 61);
            this.Skorbtn.Name = "Skorbtn";
            this.Skorbtn.Size = new System.Drawing.Size(105, 81);
            this.Skorbtn.TabIndex = 11;
            this.Skorbtn.Text = "Skorları Görüntüle";
            this.Skorbtn.UseVisualStyleBackColor = true;
            this.Skorbtn.Click += new System.EventHandler(this.Skorbtn_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 362);
            this.Controls.Add(this.Skorbtn);
            this.Controls.Add(this.grpOyuncu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.btnbaslat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGiris";
            this.Text = "Buton Yakalama Oyunu";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOyuncu.ResumeLayout(false);
            this.grpOyuncu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdZor;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.RadioButton rdKolay;
        private System.Windows.Forms.GroupBox grpOyuncu;
        public System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblsoyad;
        public System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Button Skorbtn;
    }
}
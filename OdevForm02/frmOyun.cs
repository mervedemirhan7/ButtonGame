using DosyaIslemleriLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevForm02
{
    public partial class frmOyun : Form
    {
        
        Random rnd = new Random();
        OyunInfo oyun;
         public frmOyun(OyunInfo oyun) //bilgileri oyuninfo tipinde birşeyler alıyor

        {    InitializeComponent();
            this.lbloyuncu.Text = "Ad:" + oyun.Ad + "\nSoyad:" + oyun.Soyad;
            this.oyun = oyun;
                   
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            oyun.Süre--;
            lblsure.Text = "Kalan süre: " + oyun.Süre;
            if (oyun.Süre == 0)
            {
                SkorKaydet();
                timer1.Stop();
                btnyakala.Enabled = false;
                
               DialogResult cvp= MessageBox.Show("Süre doldu! Yeniden Baslatmak istiyor musunuz?" + lbloyuncu.Text + " Puanınız: " + oyun.Puan,"Yeniden Baslatma Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (cvp==DialogResult.Yes)
                {
                    SeviyeIslemleri();
                    OyunuBaslat();

                }
                else
                {
                    this.Close();
                    frmGiris frm = (frmGiris)Application.OpenForms["frmGiris"]; //mevcut nesneyi göstermek için
                    frm.Show();
                }
                
            }
        }

        private void btnyakala_MouseMove(object sender, MouseEventArgs e)
        {
            Point kac = new Point(rnd.Next(Math.Abs(this.ClientSize.Width - btnyakala.Width - pnlBilgi.Width)), rnd.Next(Math.Abs(this.ClientSize.Height - btnyakala.Height)));

            btnyakala.Location = kac;
            oyun.Puan++;
            lblpuan.Text = "Puanınız: " + oyun.Puan;
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            btnyakala.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            SeviyeIslemleri();
            OyunuBaslat();
        }

        void OyunuBaslat()
        {
            btnyakala.Enabled = true;
            oyun.Puan = 0;
            lblpuan.Text = "Puanınız: " + oyun.Puan;
            lblsure.Text = "Kalan süre: " + oyun.Süre;
            timer1.Start();
        }

        void SeviyeIslemleri()
        {
            //switch (oyun.Seviye)
            //{
            //    case "Kolay":
            //        oyun.Süre = 30;
            //        this.Size = new Size(300, 300);
            //        break;
            //    case "Orta":
            //        oyun.Süre = 20;
            //        this.Size = new Size(500, 500);
            //        break;
            //    case "Zor":
            //        oyun.Süre = 10;
            //        this.Size = new Size(700, 700);
            //        break;
            //    default:
            //        break;
            //}
            //Yukarıdaki işlemleri enum tipinde aşağıdaki gibi yapabiliriz
            switch (oyun.Seviye)
            {
                case Seviyeler.Kolay:
                    oyun.Süre = 30;
                    this.Size = new Size(300, 300);
                    break;
                case Seviyeler.Orta:
                    oyun.Süre = 20;
                    this.Size = new Size(500, 500);
                    break;
                case Seviyeler.Zor:
                    oyun.Süre = 10;
                    this.Size = new Size(700, 700);
                    break;
                default:
                    break;
            }
        }

        private void frmOyun_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGiris frm = (frmGiris)Application.OpenForms["frmGiris"];
            frm.txtad.Text = "";
            frm.txtsoyad.Text = "";
            frm.txtad.BackColor = Color.White;
            frm.txtsoyad.BackColor = Color.White;
        }

        void SkorKaydet()
        {
            DosyaIslem d = new DosyaIslem();
            StringBuilder sb = new StringBuilder(); //string değişken içine formatlı bir değer atamadığımızdan stringbuilder kullanıldı
            sb.AppendFormat("Ad:{0}\r\nSoyad:{1}\r\nSkor:{2}\r\nTarih:{3}", oyun.Ad, oyun.Soyad, oyun.Puan, DateTime.Now);
            d.DosyaKaydet(Application.StartupPath + @"\skorlar.txt", sb.ToString());

        }

       
    }
}

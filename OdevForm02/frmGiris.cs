using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevForm02
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {

            InitializeComponent();

        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            //Size sz; int sure;
            Seviyeler seviye;
            string hatamsg = BoslukKontrol();
            if (hatamsg == string.Empty)
            {
                if (rdKolay.Checked)
                {
                    //sz = new Size(300, 300);
                    //sure = 30;
                    seviye = Seviyeler.Kolay;

                }
                else if (rdOrta.Checked)
                {
                    //sz = new Size(500, 500);
                    //sure = 20;
                    seviye = Seviyeler.Orta;
                }
                else if (rdZor.Checked)
                {
                    //sz = new Size(700, 700);
                    //sure = 10;
                    seviye = Seviyeler.Zor;
                }
                else
                {
                    MessageBox.Show("Seviye Seçiniz");
                    return;
                }
                //OyunInfo oyn = new OyunInfo();
                //oyn.Ad = txtad.Text;
                //oyn.Soyad = txtsoyad.Text;
                //oyn.Seviye = seviye;

                //yukarıdaki yerine aşağıdakiler de yazılabilir

                //OyunInfo oyn1 = new OyunInfo { Ad = txtad.Text, Soyad = txtsoyad.Text, Seviye = seviye };


                frmOyun frm1 = new frmOyun(new OyunInfo { Ad = txtad.Text, Soyad = txtsoyad.Text, Seviye = seviye });

                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(hatamsg + "\nGiriniz");
            }
        }

        //bool BoslukKontrol()
        //{
        //    bool sonuc = false;

        //    foreach (Control item in this.Controls)
        //    {
        //        if (item is TextBox && item.Text==String.Empty)
        //        {
        //            item.BackColor = Color.Red;
        //            MessageBox.Show(item.Tag+" Giriniz!");
        //            sonuc = true;
        //        }                
        //    }
        //    return sonuc;
        //}

        string BoslukKontrol()
        {
            string hatamsg = string.Empty;

            foreach (Control item in this.Controls["grpOyuncu"].Controls)
            {
                if (item is TextBox && item.Text == String.Empty)
                {
                    item.BackColor = Color.Red;
                    hatamsg += "\n" + item.Tag;
                }
            }
            return hatamsg;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.BackColor != Color.White)
            {
                txt.BackColor = Color.White;
            }
            else if (txt.Text == string.Empty)
            {
                txt.BackColor = Color.Red;
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            SetTxtChanged();
        }

        void SetTxtChanged()
        {
            foreach (Control item in this.Controls["grpOyuncu"].Controls)
            {
                if (item is TextBox)
                {
                    item.TextChanged += txt_TextChanged;
                }
            }
        }

        private void Skorbtn_Click(object sender, EventArgs e)
        {
            frmSkor frm1 = new frmSkor();
            frm1.Show();
            this.Hide();
        }
    }
}

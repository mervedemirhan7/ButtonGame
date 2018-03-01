
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
    public partial class frmSkor : Form
    {
        public frmSkor()
        {
            InitializeComponent();
        }

        private void frmSkor_Load(object sender, EventArgs e)
        {
            try
            {
                DosyaIslem d = new DosyaIslem();
                Skortxt.Text = d.DosyaOku(Application.StartupPath + @"\skorla.txt");
            }
            catch (DosyaBulunamadiException ex)
            {
                MessageBox.Show(ex.Errmsg+"  "+ex.Path);
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Hata!");
            }
            
        }
    }
}

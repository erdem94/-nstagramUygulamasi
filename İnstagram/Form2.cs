using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnstagram
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
                if (txtGirisSifre.Text== kayit.Sifre.ToString() && txtGirisKullaniciAdi.Text== kayit.KullaniciAdi)
                {
                  Form3 form = new Form3();
                  form.Show();
                    
                }
                else
                {
                    MessageBox.Show("Sifre veya kullanıcı adı hatalı");
                }
                
           
            
                
                
           
        }
    }
}

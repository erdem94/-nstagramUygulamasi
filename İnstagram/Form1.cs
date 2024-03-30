using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnstagram
{
    public partial class Form1 : Form
    {
        public List<Kayit>listKayit=new List<Kayit>();
        public Kayit kayit = new Kayit();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {

                kayit.KullaniciAdi = txtKullaniciAdi.Text;
                kayit.Sifre = Convert.ToInt32(txtSifre.Text);
                listKayit.Add(kayit);
                Bagla();
                txtAdSoyad.Clear();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtSifreTekrar.Clear();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
                txtAdSoyad.Clear();
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtSifreTekrar.Clear();
            }

        }
        private void Bagla()
        {
            kayit.AdSoyad = txtAdSoyad.Text;
            kayit.KullaniciAdi = txtKullaniciAdi.Text;
            kayit.Sifre = Convert.ToInt32(txtSifre.Text);
            kayit.SifreTekrar = Convert.ToInt32(txtSifreTekrar.Text);

        }
    }
}

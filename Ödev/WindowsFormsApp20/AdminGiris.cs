using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "1234")
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı Hatalı");
        } 
    }
}

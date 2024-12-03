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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr =new AdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr= new FrmYeniMusteri();
            fr.Show();
            this.Hide();    
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }
        // Hande
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}

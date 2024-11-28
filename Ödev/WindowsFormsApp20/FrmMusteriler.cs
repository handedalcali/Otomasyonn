using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp20
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SERANUT\SQLEXPRESS02;Initial Catalog=AtacanOteli;Integrated Security=True");
        private void verilergoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

            
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;
        private void FrmMusteriler_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefonNo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[1].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[1].Text;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
         baglanti.Open();
         SqlCommand komut = new SqlCommand("uptade MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" +TxtSoyadi.Text + "',Cinsiyet='" +comboBox1.Text + "',Telefon='" +MskTelefonNo.Text + "',Mail='" +TxtMail.Text +"',TC='" +TxtTcNo.Text +"',OdaNo='" +TxtOdaNo.Text + "',Ucret='" +TxtUcret.Text + "',GirisTarihi='" +DtpGirisTarihi.Value.ToString("yyyy.MM.dd") + "',CikisTarihi='" +DtpCikisTarihi.Value.ToString("yyyy.MM.dd")+ "'where Musteriid="+id+ "", baglanti);
         komut.ExecuteNonQuery();
         baglanti.Close();
          verilergoster();
        }   


        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid = ("+id+")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTelefonNo.Text = "";
            TxtMail.Text = "";
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = "";



        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefonNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("uptade MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTelefonNo.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTcNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy.MM.dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy.MM.dd") + "'where Musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }
    }
}

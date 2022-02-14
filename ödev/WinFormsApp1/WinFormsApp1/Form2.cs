using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Ekleme_islemi()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            string ekle = "insert into Tablo4 (Adsoyad,Telefon,Sifre) values(@adsoyad,@telefon,@sifre)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);

            komut.Parameters.AddWithValue("@adsoyad",txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@telefon",txtTelefon.Text);
            komut.Parameters.AddWithValue("@sifre",txtSifre2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.ShowDialog(); 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekleme_islemi();
            txtTelefon.Clear();
            txtSifre2.Clear();
            txtAdsoyad.Clear();
        }
    }
}

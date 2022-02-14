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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select Adsoyad,Telefon,Sifre from Tablo4 where Adsoyad=@adsoyad and Telefon=Telefon and Sifre=@sifre ", baglanti);
                sorgu.Parameters.AddWithValue("@adsoyad",txtAdsoyad.Text);
                sorgu.Parameters.AddWithValue("@telefon",txtTelefon.Text);
                sorgu.Parameters.AddWithValue("@sifre",txtSifre.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader(); 

                if (dr.Read())                                   
                {
                    Form7 form7 = new Form7 ();
                    form7.ShowDialog(); 
                    this.Visible = false; 
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("giriş başarısız");
                }
            }
            catch
            {
                MessageBox.Show("hata!");
            }
        }
    }
}

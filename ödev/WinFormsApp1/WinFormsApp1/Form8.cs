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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.Adsoyad;
            textBox2.Text = Program.Telefon;
            textBox3.Text = Program.Sifre;
            textBox4.Text = Program.Kimlik;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo4 set Adsoyad=@adsoyad,Telefon=@telefon,Sifre=@sifre where Kimlik=@kimlik", baglanti);
            komut.Parameters.AddWithValue("@adsoyad",textBox1.Text);
            komut.Parameters.AddWithValue("@telefon",textBox2.Text);
            komut.Parameters.AddWithValue("@sifre", textBox3.Text);
            komut.Parameters.AddWithValue("@kimlik",textBox4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("düzenleme başarılı");
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

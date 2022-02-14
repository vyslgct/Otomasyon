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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo3 set Kod=@kod,Urun_adı=@urun_adı,Fiyat=@fiyat where Kimlik=@kimlik", baglanti);
            komut.Parameters.AddWithValue("@kod", textBox1.Text);
            komut.Parameters.AddWithValue("@urun_adı", textBox2.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@kimlik", textBox4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("düzenleme başarılı");
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Visible=false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.Kod;
            textBox2.Text = Program.Urun_adı;
            textBox3.Text = Program.Fiyat;
            textBox4.Text = Program.Kimlik;
        }
    }
}

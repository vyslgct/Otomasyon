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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();  
            form5.ShowDialog();
            this.Visible=false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
                baglanti.Open();
                OleDbCommand sorgu = new OleDbCommand("select ID,sifre from Tablo1  where ID=@ıd and sifre=@sifre ", baglanti);
                sorgu.Parameters.AddWithValue("@ıd", textBox1.Text);
                sorgu.Parameters.AddWithValue("@sifre", textBox2.Text);
                OleDbDataReader dr;
                dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                   panel1.Visible = true;
                    panel2.Visible = false;
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

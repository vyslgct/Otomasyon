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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adptr = new OleDbDataAdapter("select * from Tablo3 order by Kimlik", baglanti);
            adptr.Fill(ds, "okunan");
            dataGridView1.DataSource = ds.Tables["okunan"];
            baglanti.Close();
        }
        public void Ekleme_islemi()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            string ekle = "insert into Tablo3(Kod,Urun_adı,Fiyat) values(@kod,@urun_adı,@fiyat)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);

            komut.Parameters.AddWithValue("@kod", textBox1.Text);
            komut.Parameters.AddWithValue("@urun_adı", textBox2.Text);
            komut.Parameters.AddWithValue("@fiyat", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ekleme_islemi();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            goster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            goster();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand("delete from Tablo3 where Kimlik=@kimlik ", baglanti);
            guncelle.Parameters.AddWithValue("@kimlik", secili_kayit);

            DialogResult onay = MessageBox.Show(secili_kayit + " Nolu kaydı silme gerçekleşsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Silme Başarılı");
                    goster();
                }
                baglanti.Close();
           }
           else
           {
               MessageBox.Show("Bir Kayıt seçiniz");
           }
        }
        string secili_kayit;
        bool kontrol = false;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir alan seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            secili_kayit = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            kontrol = true;
            Program.Kimlik = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            Program.Kod = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            Program.Urun_adı = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            Program.Fiyat = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            goster();
        }
    }
}

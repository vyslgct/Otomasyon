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
    public partial class Form5 : Form
    {
        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adptr = new OleDbDataAdapter("select * from Tablo4 order by Kimlik", baglanti);
            adptr.Fill(ds, "okunan");
            dataGridView1.DataSource = ds.Tables["okunan"];
            baglanti.Close();
        }
        public void Ekleme_islemi()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
            baglanti.Open();
            string ekle = "insert into Tablo4(Adsoyad,Telefon,Sifre) values(@adsoyad,@telefon,@sifre)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);

            komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekleme_islemi();
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear();
            goster();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            goster();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.ShowDialog();
            this.Visible =false;
        }
       
        private void dataGridView1_CellClic(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
         if (kontrol == true)
         {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\VEYSEL\\Desktop\\veri.accdb");
                baglanti.Open();
                OleDbCommand sil = new OleDbCommand("delete from Tablo4 where Kimlik=@kimlik ", baglanti);
                sil.Parameters.AddWithValue("@kimlik", secili_kayit);

                DialogResult onay = MessageBox.Show(secili_kayit + " Nolu kaydı silme gerçekleşsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    sil.ExecuteNonQuery();
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
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            secili_kayit = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            kontrol = true;
            Program.Kimlik= dataGridView1.Rows[secili].Cells[0].Value.ToString();
            Program.Adsoyad = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            Program.Telefon = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            Program.Sifre = dataGridView1.Rows[secili].Cells[3].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (kontrol == true)
            {
                Form8 form8 = new Form8();
                form8.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("lütfen alan seçiniz");
            }
        }
    }
}

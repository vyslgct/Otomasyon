using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayýt_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
            this.Visible = false;
        }

        private void btnCýkýs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.ShowDialog();
            this.Visible=false;
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();  
            form6.ShowDialog();
            this.Visible = false;
        }
    }
}
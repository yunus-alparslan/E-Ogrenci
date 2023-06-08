using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EÖğrenci
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DataSet1TableAdapters.Table_DersTableAdapter ders = new DataSet1TableAdapters.Table_DersTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            listeletablo();
           
        }

        void listeletablo()
        {
            dataGridView1.DataSource = ders.DersListesi();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            ders.DersEkle(textBoxisim.Text);
            listeletablo();
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            ders.Güncelle(textBoxisim.Text,byte.Parse(textBoxid.Text));
            listeletablo();
            MessageBox.Show("Başarılı Şekilde Tablo Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxisim.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxisim.Text = "";
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            ders.DersSilme(byte.Parse(textBoxid.Text));
            MessageBox.Show("Başarılı Şekilde Ders Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeletablo();
        }
    }
}

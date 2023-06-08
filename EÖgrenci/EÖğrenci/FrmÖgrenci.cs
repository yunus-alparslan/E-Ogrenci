using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EÖğrenci
{
    public partial class FrmÖgrenci : Form
    {
        public FrmÖgrenci()
        {
            InitializeComponent();
        }


        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-M8M86O5\\SQLEXPRESS;Initial Catalog=EÖgrenci;Integrated Security=True");


        DataSet1TableAdapters.Table_ÖğrenciTableAdapter ogr = new DataSet1TableAdapters.Table_ÖğrenciTableAdapter();




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        void listeleogrenci()
        {
            dataGridView1.DataSource = ogr.Öğrenci();
        }



        private void FrmÖgrenci_Load(object sender, EventArgs e)
        {
            listeleogrenci();

            bağlanti.Open();
            SqlCommand klp = new SqlCommand("Select * from Table_Kulüp",bağlanti);
            SqlDataAdapter dr = new SqlDataAdapter(klp);

            DataTable dt = new DataTable();
            dr.Fill(dt); 

            comboBoxKulüp.DisplayMember = "KULUPAD";
            comboBoxKulüp.ValueMember = "KULUPİD";
            comboBoxKulüp.DataSource = dt;
            bağlanti.Close();


            





        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            ogr.OgrenciEkle(textBoxisim.Text, textBoxsoyad.Text, byte.Parse(comboBoxKulüp.SelectedValue.ToString()), comboBoxcinsiyet.Text);
            listeleogrenci();
            MessageBox.Show("Başarılı Şekilde Tabloya Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
        }


    private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            ogr.ÖgrenciSil(byte.Parse(textBoxid.Text));
            listeleogrenci();
            MessageBox.Show("Başarılı Şekilde Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxisim.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxKulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxcinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void temizle()
        {
            textBoxid.Text = "";
            textBoxisim.Text = "";
            textBoxsoyad.Text = "";
            comboBoxKulüp.Text = "Seçim Yapınız";
            comboBoxcinsiyet.Text = "Seçim Yapınız";
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            ogr.ÖgrenciGüncelle(textBoxisim.Text, textBoxsoyad.Text, byte.Parse(comboBoxKulüp.SelectedValue.ToString()), comboBoxcinsiyet.Text,byte.Parse(textBoxid.Text));
            listeleogrenci();
            MessageBox.Show("Başarılı Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  ogr.ÖğrenciGetir(textBox1.Text);
            dataGridView1.DataSource = ogr.ÖğrenciGetir(textBoxara.Text);
        }
    }
}

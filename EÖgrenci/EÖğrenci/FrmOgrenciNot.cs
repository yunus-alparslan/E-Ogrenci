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
    public partial class FrmOgrenciNot : Form
    {
        public FrmOgrenciNot()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-M8M86O5\\SQLEXPRESS;Initial Catalog=EÖgrenci;Integrated Security=True");




        private void FrmOgrenciNot_Load(object sender, EventArgs e)
        {



            veri();
        }

        // Değişkenler


        DataSet1TableAdapters.Table_NotlarTableAdapter notlar = new DataSet1TableAdapters.Table_NotlarTableAdapter();



        int toplam=0, s1 = 0, s2 = 0, s3 = 0, proje = 0;
        double ortalama;



        void veri()
        {
            bağlanti.Open();
            SqlCommand tara = new SqlCommand("Select * from Table_Ders", bağlanti);
            SqlDataAdapter dr = new SqlDataAdapter(tara);
            DataTable dt = new DataTable();
            dr.Fill(dt);


            comboBox1.DisplayMember = "DERSAD";
            comboBox1.ValueMember = "DERSİD";
            comboBox1.DataSource = dt;
            bağlanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = notlar.GetirNotları(byte.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            hesapla();
            MessageBox.Show("Hesaplandı");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = notlar.GetirNotları(byte.Parse(textBox1.Text));

           


          
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxsınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxsvına2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBosvına3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
           

        }

        void hesapla()
        {

            s1 = Convert.ToInt32(textBoxsınav1.Text);
            s2 = Convert.ToInt32(textBoxsvına2.Text);
            s3 = Convert.ToInt32(textBosvına3.Text);
            proje = Convert.ToInt32(textBoxproje.Text);

            ortalama = (s1 + s2 + s3 + proje) / 4;

           

            textBoxortalama.Text = ortalama.ToString();


            if (ortalama >= 50)
            {

                MessageBox.Show("Geçti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Text = "Geçti";
                

            }
            else if (ortalama <= 50)
            {
                MessageBox.Show("Kaldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Text = "Kaldı";
            }
            else
            {
                MessageBox.Show("Geçersiz Değer", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //void hesaplaortalamaögrenci()
        //{
        //    toplam = Convert.ToInt32(textBoxsınav1.Text) + Convert.ToInt32(textBoxsvına2.Text) + Convert.ToInt32(textBosvına3.Text) / 3;
        //    label10.Text = toplam.ToString();


        //}

        void listeletekrar()
        {
            dataGridView1.DataSource = notlar.GetirNotları(byte.Parse(textBox1.Text));
        }



        private void button2_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand güncelle = new SqlCommand("Update Table_Notlar Set SINAV1=@p1,SINAV2=@p2,SINAV3=@p3,PROJE=@p4,ORTALAMA=@p5,DURUM=@p6 WHERE NOTID=@p7", bağlanti);
            güncelle.Parameters.AddWithValue("@p1", textBoxsınav1.Text);
            güncelle.Parameters.AddWithValue("@p2", textBoxsvına2.Text);
            güncelle.Parameters.AddWithValue("@p3", textBosvına3.Text);
            güncelle.Parameters.AddWithValue("@p4", textBoxproje.Text);
            güncelle.Parameters.AddWithValue("@p5", textBoxortalama.Text);
            güncelle.Parameters.AddWithValue("@p6", comboBox2.Text);
            güncelle.Parameters.AddWithValue("@p7", textBox7.Text);
            güncelle.ExecuteNonQuery();
            bağlanti.Close();
            MessageBox.Show("Güncellendi Başarılı Şekilde", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeletekrar();


        }
    }
}

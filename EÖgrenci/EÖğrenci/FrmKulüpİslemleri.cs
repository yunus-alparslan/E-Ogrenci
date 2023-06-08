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
    public partial class FrmKulüpİslemleri : Form
    {
        public FrmKulüpİslemleri()
        {
            InitializeComponent();
        }

        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-M8M86O5\\SQLEXPRESS;Initial Catalog=EÖgrenci;Integrated Security=True");



        void kulüplistesi()
        {

            bağlanti.Open();
            SqlCommand listelekulüp = new SqlCommand("Select * from Table_Kulüp",bağlanti);

            SqlDataAdapter dr = new SqlDataAdapter(listelekulüp);
            DataTable dt = new DataTable();

            dataGridView1.DataSource = dt;

            dr.Fill(dt);

            bağlanti.Close();
        }
        private void FrmKulüpİslemleri_Load(object sender, EventArgs e)
        {
            kulüplistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxisim.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand eklekulüp = new SqlCommand("insert into Table_Kulüp(KULUPAD) values(@P11)", bağlanti);
            eklekulüp.Parameters.AddWithValue("@P11", textBoxisim.Text);
            eklekulüp.ExecuteNonQuery();
            bağlanti.Close();
            MessageBox.Show("Başarılı Şekilde Kulüp Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             kulüplistesi();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxisim.Text = "";
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand deletekulüp = new SqlCommand("Delete from Table_Kulüp where KULUPİD=@P1",bağlanti);
            deletekulüp.Parameters.AddWithValue("@P1", textBoxid.Text);
            deletekulüp.ExecuteNonQuery();
            bağlanti.Close();
            MessageBox.Show("Başarılı Şekilde Kulüp Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kulüplistesi();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
 
            try
            {
                bağlanti.Open();
                SqlCommand güncellekulüp = new SqlCommand("Update Table_Kulüp Set KULUPAD=@A1 where KULUPİD=@P1", bağlanti);

                güncellekulüp.Parameters.AddWithValue("@A1", textBoxisim.Text);
                güncellekulüp.Parameters.AddWithValue("@P1", textBoxid.Text);
                güncellekulüp.ExecuteNonQuery();
                bağlanti.Close();
                kulüplistesi();
                MessageBox.Show("Başarılı Şekilde Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch
            {
                MessageBox.Show("20 Karakterli Kulüp İsmi Giriniz ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }   
           
        }


       

    }
}

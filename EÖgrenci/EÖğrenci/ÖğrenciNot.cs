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
    public partial class ÖğrenciNot : Form
    {
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-M8M86O5\\SQLEXPRESS;Initial Catalog=EÖgrenci;Integrated Security=True");

        public ÖğrenciNot()
        {
            InitializeComponent();
        }


        public int no;
        private void ÖğrenciNot_Load(object sender, EventArgs e)
        {
            label1.Text= no.ToString();
            bağlanti.Open();
            SqlCommand notlarlistesi = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM FROM Table_Notlar INNER JOIN Table_Ders On Table_Notlar.DERSİD = Table_Ders.DERSİD Where OGRİD =@P1",bağlanti);
            notlarlistesi.Parameters.AddWithValue("@P1", label1.Text);
            SqlDataAdapter dt = new SqlDataAdapter(notlarlistesi);
            DataTable dtx = new DataTable();
            dataGridView1.DataSource = dtx;
            dt.Fill(dtx);
            bağlanti.Close();


            bağlanti.Open();
            SqlCommand getirbilgileri = new SqlCommand("Select * from Table_Öğrenci where OGRİD=@P2",bağlanti);
            getirbilgileri.Parameters.AddWithValue("@P2", label1.Text);
            SqlDataReader dr = getirbilgileri.ExecuteReader();

            while (dr.Read())
            {
                label4.Text = dr[1].ToString();
                label5.Text = dr[2].ToString();
            }
            bağlanti.Close();
        }   
    }
}

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
    public partial class FrmÖğretmenler : Form
    {
        public FrmÖğretmenler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Table_ÖğretmenTableAdapter ögretmen = new DataSet1TableAdapters.Table_ÖğretmenTableAdapter();
        private void FrmÖğretmenler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ögretmen.GetirÖğretmen();

        }
    }
}

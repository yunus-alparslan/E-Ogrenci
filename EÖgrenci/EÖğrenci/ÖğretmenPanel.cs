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
    public partial class ÖğretmenPanel : Form
    {
        public ÖğretmenPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulüpİslemleri frmkulüpislem = new FrmKulüpİslemleri();
            frmkulüpislem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler drsfrm = new FrmDersler();
            drsfrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmÖgrenci frmogr = new FrmÖgrenci();
            frmogr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOgrenciNot frmnot = new FrmOgrenciNot();
            frmnot.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmÖğretmenler ögr = new FrmÖğretmenler();
            ögr.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

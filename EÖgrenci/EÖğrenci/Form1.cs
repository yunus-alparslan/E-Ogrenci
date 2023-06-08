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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ÖğrenciNot frmnot = new ÖğrenciNot();
            frmnot.no = int.Parse(textBox1.Text);
            frmnot.Show();


            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ÖğretmenPanel frmpanel = new ÖğretmenPanel();
            frmpanel.Show();
            this.Hide();
        }
    }
}

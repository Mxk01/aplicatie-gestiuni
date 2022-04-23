using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectCC1
{
    public partial class Rapoarte : Form
    {
        Boolean isChecked = false;
        public Rapoarte()
        {
            InitializeComponent();
            comboBox1.Hide();

        }

        private void Rapoarte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

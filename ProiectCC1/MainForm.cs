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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void operatiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void nomenclatoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nomenclatoareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse prod = new Produse();
            prod.ShowDialog();
        }

        private void intrariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intrari intrari = new Intrari();
            intrari.ShowDialog();
        }

        private void iesiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iesiri iesiri = new Iesiri();
            iesiri.ShowDialog();
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapoarte rapoarte = new Rapoarte();
            rapoarte.ShowDialog();
        }

        private void gestiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestiuni gest = new Gestiuni();
            gest.ShowDialog();
        }

        private void parteneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parteneri part = new Parteneri();
            part.ShowDialog();
        }
    }
}

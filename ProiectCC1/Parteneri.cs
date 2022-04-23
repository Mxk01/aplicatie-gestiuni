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
    public partial class Parteneri : Form
    {
        public Parteneri()
        {
            InitializeComponent();
        }

        private void parteneriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parteneriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parteneriDataSet);

        }

        private void Produse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteneriDataSet.parteneri' table. You can move, or remove it, as needed.
            this.parteneriTableAdapter.Fill(this.parteneriDataSet.parteneri);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

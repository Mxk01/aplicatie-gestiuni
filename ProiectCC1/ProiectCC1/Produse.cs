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
    public partial class Produse : Form
    {
        public Produse()
        {
            InitializeComponent();
        }

        private void produseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.produseDataSet);

        }

        private void Produse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produseDataSet.produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.produseDataSet.produse);

        }

        private void produseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

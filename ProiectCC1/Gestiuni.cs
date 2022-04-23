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
    public partial class Gestiuni : Form
    {
        public Gestiuni()
        {
            InitializeComponent();
        }

        private void gestiuniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestiuniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestiuniDataSet);

        }

        private void Gestiuni_Load(object sender, EventArgs e)
        {
          

        }
    }
}

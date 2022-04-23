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
    public partial class Intrari : Form
    {
       

        Boolean deleteItem = false;
        public Intrari()
        {
            InitializeComponent();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Intrari_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            // TODO: This line of code loads data into the 'parteneriDataSet.parteneri' table. You can move, or remove it, as needed.
            this.parteneriTableAdapter.Fill(this.parteneriDataSet.parteneri);
            // TODO: This line of code loads data into the 'proiectDataSet.intrari' table. You can move, or remove it, as needed.
            this.intrariTableAdapter.Fill(this.proiectDataSet.intrari);
           
            var intrariSelect = (
           from intrare in db.intraris
           select new {intrare.partener}).ToList();
          
             comboBox1.DataSource = intrariSelect;

            var partenersNamesQuery = from
                                  g in db.intraris
                                      join m in db.parteneris

                                      on g.partener equals m.ID

                                      select new
                                      {

                                          Denumire = m.denumire

                                      };

            comboBox1.DisplayMember = "Denumire";
       
            comboBox1.DataSource = partenersNamesQuery;


            var gestiuniNamesQuery = from
                              g in db.intraris
                                      where g.gestiune == 1
                                      join m in db.gestiunis

                                      on g.gestiune equals m.ID

                                      select new
                                      {

                                          Denumire = m.denumire

                                      };


            comboBox2.DataSource = gestiuniNamesQuery;


            db.SubmitChanges();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* var partenersNamesQuery = from
                              g in db.intraris
                                       where g.denumire == Convert.ToInt32(comboBox2.selectedValue)
                                       join m in db.parteneris

                                       on g.partener equals m.ID

                                       select new
                                       {
                                           ID = m.ID,
                                           Denumire = m.denumire
                                           ,Cod = m.cod,
                                           Cui = m.cui,
                                           Adresa = m.adresa

                                       };


             dataGridView1.DataSource = partenersNamesQuery.ToList();
     */
           


        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            deleteItem = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form2 = new MainForm(); //you can replace the form2 (not the Form2) with anything you want
            form2.ShowDialog();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          // get value of first cell of selected row
          //  MessageBox.Show(e.RowIndex.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show(deleteItem.ToString());
            int index = e.RowIndex;
            // get current row
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            // get id of entry
            int id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            if (deleteItem && id!=null)
            {
                var q =

                  from x in db.intraris

                    where x.ID == id

                     select x;
                if(q!=null)
                {
                    MessageBox.Show(q.ToList().ToString());
                }

                var remove = (from removableItem in db.intraris
                              where removableItem.ID == id
                            
                              select removableItem).FirstOrDefault();

                if (remove != null)
                {
                    db.intraris.DeleteOnSubmit(remove);
                  
                }
                else
                {
                    MessageBox.Show($"Couldn't find any entry with id of {id}");
                }


            }
            //  MessageBox.Show(selectedRow.Cells[2].Value.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
        // https://www.youtube.com/watch?v=6y65Qf8GzcI&list=PLFDH5bKmoNqyDKntkVv-NURTAlPIhMPqA&index=4
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
             
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /*var tempFileName = db.SchedulesAndFiles
                         .Where(x  => x.ID == ID )
                         .OrderByDescending(x => x.ID)
                         .First()
                         .Select(x => x.Filename);
                         */

            // 1. GET LATEST ID value in db
            // 2. Increment to next  (If last ID was 2 in DB then increment to 3)
            // 3. Get values of fields and store them in the db

        }
    }
}

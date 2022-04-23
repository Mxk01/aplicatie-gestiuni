namespace ProiectCC1
{
    partial class Parteneri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.Label denumireLabel;
            System.Windows.Forms.Label cuiLabel;
            System.Windows.Forms.Label adresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parteneri));
            this.parteneriDataSet = new ProiectCC1.parteneriDataSet();
            this.parteneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parteneriTableAdapter = new ProiectCC1.parteneriDataSetTableAdapters.parteneriTableAdapter();
            this.tableAdapterManager = new ProiectCC1.parteneriDataSetTableAdapters.TableAdapterManager();
            this.parteneriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parteneriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.cuiTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            codLabel = new System.Windows.Forms.Label();
            denumireLabel = new System.Windows.Forms.Label();
            cuiLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parteneriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteneriBindingNavigator)).BeginInit();
            this.parteneriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.ForeColor = System.Drawing.Color.Cornsilk;
            iDLabel.Location = new System.Drawing.Point(552, 55);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.ForeColor = System.Drawing.Color.Cornsilk;
            codLabel.Location = new System.Drawing.Point(545, 103);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(28, 13);
            codLabel.TabIndex = 3;
            codLabel.Text = "cod:";
            // 
            // denumireLabel
            // 
            denumireLabel.AutoSize = true;
            denumireLabel.ForeColor = System.Drawing.Color.Cornsilk;
            denumireLabel.Location = new System.Drawing.Point(520, 151);
            denumireLabel.Name = "denumireLabel";
            denumireLabel.Size = new System.Drawing.Size(53, 13);
            denumireLabel.TabIndex = 5;
            denumireLabel.Text = "denumire:";
            // 
            // cuiLabel
            // 
            cuiLabel.AutoSize = true;
            cuiLabel.ForeColor = System.Drawing.Color.Cornsilk;
            cuiLabel.Location = new System.Drawing.Point(533, 200);
            cuiLabel.Name = "cuiLabel";
            cuiLabel.Size = new System.Drawing.Size(24, 13);
            cuiLabel.TabIndex = 7;
            cuiLabel.Text = "cui:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.ForeColor = System.Drawing.Color.Cornsilk;
            adresaLabel.Location = new System.Drawing.Point(520, 242);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(42, 13);
            adresaLabel.TabIndex = 9;
            adresaLabel.Text = "adresa:";
            // 
            // parteneriDataSet
            // 
            this.parteneriDataSet.DataSetName = "parteneriDataSet";
            this.parteneriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parteneriBindingSource
            // 
            this.parteneriBindingSource.DataMember = "parteneri";
            this.parteneriBindingSource.DataSource = this.parteneriDataSet;
            // 
            // parteneriTableAdapter
            // 
            this.parteneriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.parteneriTableAdapter = this.parteneriTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProiectCC1.parteneriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // parteneriBindingNavigator
            // 
            this.parteneriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.parteneriBindingNavigator.BindingSource = this.parteneriBindingSource;
            this.parteneriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.parteneriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.parteneriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.parteneriBindingNavigatorSaveItem});
            this.parteneriBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.parteneriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.parteneriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.parteneriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.parteneriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.parteneriBindingNavigator.Name = "parteneriBindingNavigator";
            this.parteneriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.parteneriBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.parteneriBindingNavigator.TabIndex = 0;
            this.parteneriBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // parteneriBindingNavigatorSaveItem
            // 
            this.parteneriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parteneriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parteneriBindingNavigatorSaveItem.Image")));
            this.parteneriBindingNavigatorSaveItem.Name = "parteneriBindingNavigatorSaveItem";
            this.parteneriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.parteneriBindingNavigatorSaveItem.Text = "Save Data";
            this.parteneriBindingNavigatorSaveItem.Click += new System.EventHandler(this.parteneriBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteneriBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(579, 52);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // codTextBox
            // 
            this.codTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteneriBindingSource, "cod", true));
            this.codTextBox.Location = new System.Drawing.Point(579, 103);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(100, 20);
            this.codTextBox.TabIndex = 4;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteneriBindingSource, "denumire", true));
            this.denumireTextBox.Location = new System.Drawing.Point(579, 151);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(100, 20);
            this.denumireTextBox.TabIndex = 6;
            // 
            // cuiTextBox
            // 
            this.cuiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteneriBindingSource, "cui", true));
            this.cuiTextBox.Location = new System.Drawing.Point(579, 197);
            this.cuiTextBox.Name = "cuiTextBox";
            this.cuiTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuiTextBox.TabIndex = 8;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parteneriBindingSource, "adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(579, 242);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.cuiDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parteneriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 379);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            // 
            // cuiDataGridViewTextBoxColumn
            // 
            this.cuiDataGridViewTextBoxColumn.DataPropertyName = "cui";
            this.cuiDataGridViewTextBoxColumn.HeaderText = "cui";
            this.cuiDataGridViewTextBoxColumn.Name = "cuiDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // Parteneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(codLabel);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(denumireLabel);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(cuiLabel);
            this.Controls.Add(this.cuiTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.parteneriBindingNavigator);
            this.Name = "Parteneri";
            this.Text = "Parteneri";
            this.Load += new System.EventHandler(this.Produse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parteneriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteneriBindingNavigator)).EndInit();
            this.parteneriBindingNavigator.ResumeLayout(false);
            this.parteneriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private parteneriDataSet parteneriDataSet;
        private System.Windows.Forms.BindingSource parteneriBindingSource;
        private parteneriDataSetTableAdapters.parteneriTableAdapter parteneriTableAdapter;
        private parteneriDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator parteneriBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton parteneriBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox cuiTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
    }
}
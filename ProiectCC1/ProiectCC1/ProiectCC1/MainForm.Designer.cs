namespace ProiectCC1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nomenclatoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intrariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomenclatoareToolStripMenuItem,
            this.operatiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(266, 113);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(355, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nomenclatoareToolStripMenuItem
            // 
            this.nomenclatoareToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.nomenclatoareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.gestiuniToolStripMenuItem,
            this.parteneriToolStripMenuItem});
            this.nomenclatoareToolStripMenuItem.Name = "nomenclatoareToolStripMenuItem";
            this.nomenclatoareToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.nomenclatoareToolStripMenuItem.Text = "Nomenclatoare";
            this.nomenclatoareToolStripMenuItem.Click += new System.EventHandler(this.nomenclatoareToolStripMenuItem_Click_1);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // gestiuniToolStripMenuItem
            // 
            this.gestiuniToolStripMenuItem.Name = "gestiuniToolStripMenuItem";
            this.gestiuniToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gestiuniToolStripMenuItem.Text = "Gestiuni";
            this.gestiuniToolStripMenuItem.Click += new System.EventHandler(this.gestiuniToolStripMenuItem_Click);
            // 
            // parteneriToolStripMenuItem
            // 
            this.parteneriToolStripMenuItem.Name = "parteneriToolStripMenuItem";
            this.parteneriToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.parteneriToolStripMenuItem.Text = "Parteneri";
            this.parteneriToolStripMenuItem.Click += new System.EventHandler(this.parteneriToolStripMenuItem_Click);
            // 
            // operatiuniToolStripMenuItem
            // 
            this.operatiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intrariToolStripMenuItem,
            this.iesiriToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.operatiuniToolStripMenuItem.Name = "operatiuniToolStripMenuItem";
            this.operatiuniToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.operatiuniToolStripMenuItem.Text = "Operatiuni";
            // 
            // intrariToolStripMenuItem
            // 
            this.intrariToolStripMenuItem.Name = "intrariToolStripMenuItem";
            this.intrariToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.intrariToolStripMenuItem.Text = "Intrari";
            this.intrariToolStripMenuItem.Click += new System.EventHandler(this.intrariToolStripMenuItem_Click);
            // 
            // iesiriToolStripMenuItem
            // 
            this.iesiriToolStripMenuItem.Name = "iesiriToolStripMenuItem";
            this.iesiriToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.iesiriToolStripMenuItem.Text = "Iesiri";
            this.iesiriToolStripMenuItem.Click += new System.EventHandler(this.iesiriToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            this.rapoarteToolStripMenuItem.Click += new System.EventHandler(this.rapoarteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomenclatoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intrariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesiriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
    }
}
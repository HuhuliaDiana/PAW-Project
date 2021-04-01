namespace Proiect_PAW
{
    partial class Vanzari
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
            this.lvVanzari = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listăVânzăriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_PAW.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVanzari
            // 
            this.lvVanzari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvVanzari.HideSelection = false;
            this.lvVanzari.Location = new System.Drawing.Point(0, 30);
            this.lvVanzari.Name = "lvVanzari";
            this.lvVanzari.Size = new System.Drawing.Size(575, 363);
            this.lvVanzari.TabIndex = 0;
            this.lvVanzari.UseCompatibleStateImageBehavior = false;
            this.lvVanzari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Cod";
            this.columnHeader0.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Obiect";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Culoare";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pret";
            this.columnHeader4.Width = 128;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fișier";
            // 
            // incarcareToolStripMenuItem
            // 
            this.incarcareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugetToolStripMenuItem,
            this.listăVânzăriToolStripMenuItem});
            this.incarcareToolStripMenuItem.Name = "incarcareToolStripMenuItem";
            this.incarcareToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.incarcareToolStripMenuItem.Text = "Încărcare";
            // 
            // bugetToolStripMenuItem
            // 
            this.bugetToolStripMenuItem.Name = "bugetToolStripMenuItem";
            this.bugetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.bugetToolStripMenuItem.Text = "Buget";
            this.bugetToolStripMenuItem.Click += new System.EventHandler(this.bugetToolStripMenuItem_Click);
            // 
            // listăVânzăriToolStripMenuItem
            // 
            this.listăVânzăriToolStripMenuItem.Name = "listăVânzăriToolStripMenuItem";
            this.listăVânzăriToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.listăVânzăriToolStripMenuItem.Text = "Listă vânzări";
            this.listăVânzăriToolStripMenuItem.Click += new System.EventHandler(this.listăVânzăriToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculeaza buget";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vezi evoluție buget";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bugetul de azi este: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Grafic";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(176, 8);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(169, 16);
            this.userControl11.TabIndex = 8;
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 449);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvVanzari);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vanzari";
            this.Text = "Vânzări";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVanzari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcareToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem bugetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listăVânzăriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private UserControl1 userControl11;
    }
}
namespace Proiect_PAW
{
    partial class ListaMateriale
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vanzareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicăReducereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operațiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prețCrescătorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prețDescrescătorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new Proiect_PAW.UserControl1();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 333);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Cod";
            this.columnHeader0.Width = 117;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Obiect";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Culoare";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preț";
            this.columnHeader4.Width = 146;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanzareToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.aplicăReducereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // vanzareToolStripMenuItem
            // 
            this.vanzareToolStripMenuItem.Name = "vanzareToolStripMenuItem";
            this.vanzareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.vanzareToolStripMenuItem.Text = "Vânzare";
            this.vanzareToolStripMenuItem.Click += new System.EventHandler(this.vanzareToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // aplicăReducereToolStripMenuItem
            // 
            this.aplicăReducereToolStripMenuItem.Name = "aplicăReducereToolStripMenuItem";
            this.aplicăReducereToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aplicăReducereToolStripMenuItem.Text = "Aplică reducere";
            this.aplicăReducereToolStripMenuItem.Click += new System.EventHandler(this.aplicăReducereToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.operațiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcareToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fișier";
            // 
            // incarcareToolStripMenuItem
            // 
            this.incarcareToolStripMenuItem.Name = "incarcareToolStripMenuItem";
            this.incarcareToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.incarcareToolStripMenuItem.Text = "Încărcare";
            this.incarcareToolStripMenuItem.Click += new System.EventHandler(this.incarcareToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // operațiiToolStripMenuItem
            // 
            this.operațiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugăToolStripMenuItem,
            this.sortareToolStripMenuItem});
            this.operațiiToolStripMenuItem.Name = "operațiiToolStripMenuItem";
            this.operațiiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.operațiiToolStripMenuItem.Text = "Operații";
            // 
            // adaugăToolStripMenuItem
            // 
            this.adaugăToolStripMenuItem.Name = "adaugăToolStripMenuItem";
            this.adaugăToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.adaugăToolStripMenuItem.Text = "Adaugă produs";
            this.adaugăToolStripMenuItem.Click += new System.EventHandler(this.adaugăToolStripMenuItem_Click);
            // 
            // sortareToolStripMenuItem
            // 
            this.sortareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prețCrescătorToolStripMenuItem,
            this.prețDescrescătorToolStripMenuItem});
            this.sortareToolStripMenuItem.Name = "sortareToolStripMenuItem";
            this.sortareToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sortareToolStripMenuItem.Text = "Sortare";
            // 
            // prețCrescătorToolStripMenuItem
            // 
            this.prețCrescătorToolStripMenuItem.Name = "prețCrescătorToolStripMenuItem";
            this.prețCrescătorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.prețCrescătorToolStripMenuItem.Text = "Preț crescător";
            this.prețCrescătorToolStripMenuItem.Click += new System.EventHandler(this.prețCrescătorToolStripMenuItem_Click);
            // 
            // prețDescrescătorToolStripMenuItem
            // 
            this.prețDescrescătorToolStripMenuItem.Name = "prețDescrescătorToolStripMenuItem";
            this.prețDescrescătorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.prețDescrescătorToolStripMenuItem.Text = "Preț descrescător";
            this.prețDescrescătorToolStripMenuItem.Click += new System.EventHandler(this.prețDescrescătorToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aplică o reducere de:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Obiect",
            "Culoare",
            "Brand"});
            this.comboBox1.Location = new System.Drawing.Point(101, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Căutare după:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Introdu textul căutat:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 410);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Grafic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(258, 8);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(169, 16);
            this.userControl11.TabIndex = 13;
            // 
            // ListaMateriale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 444);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ListaMateriale";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vanzareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operațiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugăToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aplicăReducereToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem sortareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prețCrescătorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prețDescrescătorToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.Button button1;
        private UserControl1 userControl11;
    }
}
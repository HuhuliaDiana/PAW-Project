namespace Proiect_PAW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocDisponibilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // materialeToolStripMenuItem
            // 
            this.materialeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocDisponibilToolStripMenuItem,
            this.vanzariToolStripMenuItem});
            this.materialeToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.materialeToolStripMenuItem.Name = "materialeToolStripMenuItem";
            this.materialeToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.materialeToolStripMenuItem.Text = "Vezi materiale ";
            // 
            // stocDisponibilToolStripMenuItem
            // 
            this.stocDisponibilToolStripMenuItem.Name = "stocDisponibilToolStripMenuItem";
            this.stocDisponibilToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.stocDisponibilToolStripMenuItem.Text = "Stoc disponibil";
            this.stocDisponibilToolStripMenuItem.Click += new System.EventHandler(this.stocDisponibilToolStripMenuItem_Click);
            // 
            // vanzariToolStripMenuItem
            // 
            this.vanzariToolStripMenuItem.Name = "vanzariToolStripMenuItem";
            this.vanzariToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.vanzariToolStripMenuItem.Text = "Vândute";
            this.vanzariToolStripMenuItem.Click += new System.EventHandler(this.vanzariToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Librarie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem materialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocDisponibilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzariToolStripMenuItem;
    }
}


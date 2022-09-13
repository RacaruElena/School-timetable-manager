
namespace Proiect
{
    partial class FormVizualizare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVizualizare));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareOrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaIdProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareOrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userControl11 = new Proiect.UserControl1();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareOrarToolStripMenuItem,
            this.printareOrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareOrarToolStripMenuItem
            // 
            this.vizualizareOrarToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.vizualizareOrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completToolStripMenuItem,
            this.dupaIdProfesorToolStripMenuItem});
            this.vizualizareOrarToolStripMenuItem.Name = "vizualizareOrarToolStripMenuItem";
            this.vizualizareOrarToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.vizualizareOrarToolStripMenuItem.Text = "Vizualizare orar";
            // 
            // completToolStripMenuItem
            // 
            this.completToolStripMenuItem.Name = "completToolStripMenuItem";
            this.completToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.completToolStripMenuItem.Text = "Complet";
            this.completToolStripMenuItem.Click += new System.EventHandler(this.completToolStripMenuItem_Click);
            // 
            // dupaIdProfesorToolStripMenuItem
            // 
            this.dupaIdProfesorToolStripMenuItem.Name = "dupaIdProfesorToolStripMenuItem";
            this.dupaIdProfesorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dupaIdProfesorToolStripMenuItem.Text = "Dupa id profesor";
            this.dupaIdProfesorToolStripMenuItem.Click += new System.EventHandler(this.dupaIdProfesorToolStripMenuItem_Click);
            // 
            // printareOrarToolStripMenuItem
            // 
            this.printareOrarToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.printareOrarToolStripMenuItem.Name = "printareOrarToolStripMenuItem";
            this.printareOrarToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.printareOrarToolStripMenuItem.Text = "&Printare orar";
            this.printareOrarToolStripMenuItem.Click += new System.EventHandler(this.printareOrarToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 449);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ziua";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ora";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sala";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Profesor";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Disciplina";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.SandyBrown;
            this.userControl11.Location = new System.Drawing.Point(0, 526);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(935, 61);
            this.userControl11.TabIndex = 4;
            // 
            // FormVizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(935, 588);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVizualizare";
            this.Text = "FormVizualizare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareOrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaIdProfesorToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem printareOrarToolStripMenuItem;
        private UserControl1 userControl11;
    }
}
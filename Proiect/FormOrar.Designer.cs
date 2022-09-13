
namespace Proiect
{
    partial class FormOrar
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
            this.columnHeaderIdProfesor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDisciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEtaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControl11 = new Proiect.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStripTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Chocolate;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIdProfesor,
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderDisciplina,
            this.columnHeaderTip});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(604, 271);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeaderIdProfesor
            // 
            this.columnHeaderIdProfesor.Text = "Id profesor";
            this.columnHeaderIdProfesor.Width = 96;
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 80;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 80;
            // 
            // columnHeaderDisciplina
            // 
            this.columnHeaderDisciplina.Text = "Disciplina";
            this.columnHeaderDisciplina.Width = 90;
            // 
            // columnHeaderTip
            // 
            this.columnHeaderTip.Text = "Tip activitate";
            this.columnHeaderTip.Width = 103;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaProfesorToolStripMenuItem,
            this.stergeProfesorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 52);
            // 
            // modificaProfesorToolStripMenuItem
            // 
            this.modificaProfesorToolStripMenuItem.Name = "modificaProfesorToolStripMenuItem";
            this.modificaProfesorToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.modificaProfesorToolStripMenuItem.Text = "Modifica profesor";
            this.modificaProfesorToolStripMenuItem.Click += new System.EventHandler(this.modificaProfesorToolStripMenuItem_Click);
            // 
            // stergeProfesorToolStripMenuItem
            // 
            this.stergeProfesorToolStripMenuItem.Name = "stergeProfesorToolStripMenuItem";
            this.stergeProfesorToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.stergeProfesorToolStripMenuItem.Text = "Sterge profesor";
            this.stergeProfesorToolStripMenuItem.Click += new System.EventHandler(this.stergeProfesorToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Chocolate;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ContextMenuStrip = this.contextMenuStripTree;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(759, 125);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(340, 444);
            this.treeView1.TabIndex = 2;
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaInFisierTextToolStripMenuItem});
            this.contextMenuStripTree.Name = "contextMenuStripTree";
            this.contextMenuStripTree.Size = new System.Drawing.Size(218, 28);
            // 
            // salveazaInFisierTextToolStripMenuItem
            // 
            this.salveazaInFisierTextToolStripMenuItem.Name = "salveazaInFisierTextToolStripMenuItem";
            this.salveazaInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.salveazaInFisierTextToolStripMenuItem.Text = "Salveaza in fisier text";
            this.salveazaInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierTextToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.BackColor = System.Drawing.Color.Chocolate;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSala,
            this.columnHeaderEtaj,
            this.columnHeaderLocuri});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(66, 449);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(325, 213);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            this.listView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView2_DragEnter);
            // 
            // columnHeaderSala
            // 
            this.columnHeaderSala.Text = "Nr. sala";
            this.columnHeaderSala.Width = 100;
            // 
            // columnHeaderEtaj
            // 
            this.columnHeaderEtaj.Text = "Etaj";
            // 
            // columnHeaderLocuri
            // 
            this.columnHeaderLocuri.Text = "Numar locuri";
            this.columnHeaderLocuri.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(195, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "SALI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(893, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ORAR";
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.SandyBrown;
            this.userControl11.Location = new System.Drawing.Point(-2, -1);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1316, 61);
            this.userControl11.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(174, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adauga profesor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1314, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "FormOrar";
            this.Text = "FormOrar";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStripTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeaderIdProfesor;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderDisciplina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificaProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeProfesorToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTip;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderSala;
        private System.Windows.Forms.ColumnHeader columnHeaderEtaj;
        private System.Windows.Forms.ColumnHeader columnHeaderLocuri;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControl1 userControl11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierTextToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
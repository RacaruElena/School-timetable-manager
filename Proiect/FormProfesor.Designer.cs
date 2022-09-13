
namespace Proiect
{
    partial class FormProfesor
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonActualizeaza = new System.Windows.Forms.Button();
            this.comboBoxdisciplina = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRenunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxId.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxId.Location = new System.Drawing.Point(193, 42);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(174, 21);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Text = "Id Profesor";
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
            this.textBoxId.Validated += new System.EventHandler(this.textBoxId_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(193, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 3);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(193, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 3);
            this.label3.TabIndex = 3;
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNume.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNume.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxNume.Location = new System.Drawing.Point(193, 101);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(174, 21);
            this.textBoxNume.TabIndex = 4;
            this.textBoxNume.Text = "Nume";
            this.textBoxNume.Click += new System.EventHandler(this.textBoxNume_Click);
            this.textBoxNume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNume_Validating);
            this.textBoxNume.Validated += new System.EventHandler(this.textBoxNume_Validated);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxPrenume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrenume.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrenume.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxPrenume.Location = new System.Drawing.Point(193, 167);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(174, 21);
            this.textBoxPrenume.TabIndex = 5;
            this.textBoxPrenume.Text = "Prenume";
            this.textBoxPrenume.Click += new System.EventHandler(this.textBoxPrenume_Click);
            this.textBoxPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrenume_Validating);
            this.textBoxPrenume.Validated += new System.EventHandler(this.textBoxPrenume_Validated);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(193, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 3);
            this.label5.TabIndex = 16;
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTip.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Curs",
            "Seminar"});
            this.comboBoxTip.Location = new System.Drawing.Point(193, 341);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(456, 29);
            this.comboBoxTip.TabIndex = 17;
            this.comboBoxTip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTip_KeyDown);
            this.comboBoxTip.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxTip_Validating);
            this.comboBoxTip.Validated += new System.EventHandler(this.comboBoxTip_Validated);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.Chocolate;
            this.buttonAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdauga.FlatAppearance.BorderSize = 0;
            this.buttonAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdauga.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdauga.Location = new System.Drawing.Point(161, 414);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(131, 58);
            this.buttonAdauga.TabIndex = 19;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            this.buttonAdauga.Validating += new System.ComponentModel.CancelEventHandler(this.buttonAdauga_Validating);
            // 
            // buttonActualizeaza
            // 
            this.buttonActualizeaza.BackColor = System.Drawing.Color.Chocolate;
            this.buttonActualizeaza.FlatAppearance.BorderSize = 0;
            this.buttonActualizeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizeaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonActualizeaza.Location = new System.Drawing.Point(533, 414);
            this.buttonActualizeaza.Name = "buttonActualizeaza";
            this.buttonActualizeaza.Size = new System.Drawing.Size(137, 58);
            this.buttonActualizeaza.TabIndex = 20;
            this.buttonActualizeaza.Text = "&Actualizeaza";
            this.buttonActualizeaza.UseVisualStyleBackColor = false;
            this.buttonActualizeaza.Click += new System.EventHandler(this.buttonActualizeaza_Click);
            // 
            // comboBoxdisciplina
            // 
            this.comboBoxdisciplina.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxdisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxdisciplina.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxdisciplina.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxdisciplina.FormattingEnabled = true;
            this.comboBoxdisciplina.Items.AddRange(new object[] {
            "Informatica",
            "Matematica",
            "Baze de date",
            "PAW",
            "Microeconomie",
            "Java"});
            this.comboBoxdisciplina.Location = new System.Drawing.Point(193, 254);
            this.comboBoxdisciplina.Name = "comboBoxdisciplina";
            this.comboBoxdisciplina.Size = new System.Drawing.Size(456, 29);
            this.comboBoxdisciplina.TabIndex = 21;
            this.comboBoxdisciplina.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxdisciplina_Validating);
            this.comboBoxdisciplina.Validated += new System.EventHandler(this.comboBoxdisciplina_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(193, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 21);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Disciplina";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(193, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 21);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Tip activitate";
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.BackColor = System.Drawing.Color.Chocolate;
            this.buttonRenunta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRenunta.FlatAppearance.BorderSize = 0;
            this.buttonRenunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenunta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenunta.Location = new System.Drawing.Point(341, 414);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(131, 58);
            this.buttonRenunta.TabIndex = 24;
            this.buttonRenunta.Text = "&Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = false;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxdisciplina);
            this.Controls.Add(this.buttonActualizeaza);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Button buttonAdauga;
        public System.Windows.Forms.TextBox textBoxNume;
        public System.Windows.Forms.TextBox textBoxPrenume;
        public System.Windows.Forms.ComboBox comboBoxTip;
        public System.Windows.Forms.ComboBox comboBoxdisciplina;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button buttonActualizeaza;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button buttonRenunta;
    }
}
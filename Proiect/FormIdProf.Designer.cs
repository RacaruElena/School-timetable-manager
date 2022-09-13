
namespace Proiect
{
    partial class FormIdProf
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
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl11 = new Proiect.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxid.Location = new System.Drawing.Point(68, 129);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(171, 23);
            this.textBoxid.TabIndex = 0;
            this.textBoxid.Text = "Introduceti id-ul";
            this.textBoxid.Click += new System.EventHandler(this.textBoxid_Click);
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            this.textBoxid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxid_KeyDown);
            this.textBoxid.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxid_Validating);
            this.textBoxid.Validated += new System.EventHandler(this.textBoxid_Validated);
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.Chocolate;
            this.buttonCauta.FlatAppearance.BorderSize = 0;
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCauta.Location = new System.Drawing.Point(96, 202);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(117, 37);
            this.buttonCauta.TabIndex = 2;
            this.buttonCauta.Text = "Cauta";
            this.buttonCauta.UseVisualStyleBackColor = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(68, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 2);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.SandyBrown;
            this.userControl11.Location = new System.Drawing.Point(-1, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(345, 61);
            this.userControl11.TabIndex = 4;
            // 
            // FormIdProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(344, 284);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.textBoxid);
            this.Name = "FormIdProf";
            this.Text = "FormIdProf";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCauta;
        public System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControl1 userControl11;
    }
}
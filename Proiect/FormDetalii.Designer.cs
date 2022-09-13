
namespace Proiect
{
    partial class FormDetalii
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
            this.comboBoxZiua = new System.Windows.Forms.ComboBox();
            this.buttonIntrod = new System.Windows.Forms.Button();
            this.comboBoxora = new System.Windows.Forms.ComboBox();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxZiua
            // 
            this.comboBoxZiua.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxZiua.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxZiua.FormattingEnabled = true;
            this.comboBoxZiua.Items.AddRange(new object[] {
            "Luni",
            "Marti",
            "Miercuri",
            "Joi",
            "Vineri"});
            this.comboBoxZiua.Location = new System.Drawing.Point(46, 81);
            this.comboBoxZiua.Name = "comboBoxZiua";
            this.comboBoxZiua.Size = new System.Drawing.Size(188, 28);
            this.comboBoxZiua.TabIndex = 0;
            this.comboBoxZiua.Text = "Ziua";
            this.comboBoxZiua.Click += new System.EventHandler(this.comboBoxZiua_Click);
            this.comboBoxZiua.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxZiua_Validating);
            this.comboBoxZiua.Validated += new System.EventHandler(this.comboBoxZiua_Validated);
            // 
            // buttonIntrod
            // 
            this.buttonIntrod.BackColor = System.Drawing.Color.Chocolate;
            this.buttonIntrod.FlatAppearance.BorderSize = 0;
            this.buttonIntrod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIntrod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIntrod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIntrod.Location = new System.Drawing.Point(12, 217);
            this.buttonIntrod.Name = "buttonIntrod";
            this.buttonIntrod.Size = new System.Drawing.Size(109, 47);
            this.buttonIntrod.TabIndex = 2;
            this.buttonIntrod.Text = "&Introduceti";
            this.buttonIntrod.UseVisualStyleBackColor = false;
            this.buttonIntrod.Click += new System.EventHandler(this.buttonIntrod_Click);
            // 
            // comboBoxora
            // 
            this.comboBoxora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxora.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxora.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxora.FormattingEnabled = true;
            this.comboBoxora.Items.AddRange(new object[] {
            "7:30-9:30",
            "9:30-11:30",
            "11:30-13:30",
            "13:30-15:30",
            "15:30-17:30",
            "17:30-19:30"});
            this.comboBoxora.Location = new System.Drawing.Point(46, 138);
            this.comboBoxora.Name = "comboBoxora";
            this.comboBoxora.Size = new System.Drawing.Size(188, 28);
            this.comboBoxora.TabIndex = 22;
            this.comboBoxora.Text = "Interval orar";
            this.comboBoxora.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxora_Validating);
            this.comboBoxora.Validated += new System.EventHandler(this.comboBoxora_Validated);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.BackColor = System.Drawing.Color.Chocolate;
            this.buttonRenunta.FlatAppearance.BorderSize = 0;
            this.buttonRenunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRenunta.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRenunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRenunta.Location = new System.Drawing.Point(159, 217);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(104, 47);
            this.buttonRenunta.TabIndex = 23;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = false;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDetalii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(294, 290);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.comboBoxora);
            this.Controls.Add(this.buttonIntrod);
            this.Controls.Add(this.comboBoxZiua);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "FormDetalii";
            this.Text = "FormDetalii";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonIntrod;
        public System.Windows.Forms.ComboBox comboBoxZiua;
        public System.Windows.Forms.ComboBox comboBoxora;
        private System.Windows.Forms.Button buttonRenunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
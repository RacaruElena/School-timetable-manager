using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormDetalii : Form
    {
        //FormOrar parinte;
        TreeNode t;
        public FormDetalii(TreeNode torar)
        {
            InitializeComponent();
            //parinte = this.parinte;
            t = torar;
        }

        private void buttonIntrod_Click(object sender, EventArgs e)
        {
           // t.Nodes.Add(textBoxOra.Text + " " + comboBoxZiua.Text);
             t.Text += " " + comboBoxZiua.Text + " " + comboBoxora.Text;

            this.Hide();
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            //this.Hide();
            t.Remove();
            this.Hide();
        }

        private void comboBoxZiua_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxZiua_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxZiua, "");
        }

        private void comboBoxZiua_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxZiua.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxZiua, "Trebuie introdusa ziua!");
                e.Cancel = true;
            }

        }

        private void comboBoxora_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxora, "");

        }

        private void comboBoxora_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxora.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxora, "Trebuie introdusa ora!");
                e.Cancel = true;
            }

        }
    }
}

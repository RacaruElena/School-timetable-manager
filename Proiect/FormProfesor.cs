using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormProfesor : Form
    {
        //public FormOrar parinte;
        FormOrar parinte;
        DataSet ds = new DataSet();
        SqlCommand cmd;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Orar;Integrated Security=True";
        public FormProfesor(FormOrar parinte)
        {
            InitializeComponent();
            parinte = this.parinte;
        }


        private void buttonAdauga_Click(object sender, EventArgs e)
        {

            //adaugare in baza de date
            
                SqlConnection conexiune = new SqlConnection(stringConexiune);  //conexiunea stie unde sa identifice server ul de baza de date
                conexiune.Open();
                cmd = new SqlCommand("insert into dbo.Profesori(idProfesor, nume, prenume,disciplina,tipActivitate)values('" + textBoxId.Text + "','" + textBoxNume.Text + "','" + textBoxPrenume.Text + "','" + comboBoxdisciplina.Text + "','" + comboBoxTip.Text + "')", conexiune);
                SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
                // DataSet ds = new DataSet();
                adaptor.Fill(ds);

                MessageBox.Show("Inserare cu succes");

                this.Hide();


        }

        private void buttonActualizeaza_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            cmd = new SqlCommand("update dbo.Profesori set nume=@nume, prenume=@prenume, disciplina=@disciplina, tipActivitate=@tipActivitate where idProfesor=@idProfesor", conexiune);
            SqlCommand cmd2 = new SqlCommand("update dbo.Orar set NumeProfesor='" + textBoxNume.Text + "', PrenumeProfesor=@prenume, Disciplina=@disciplina where IdProfesor=@idProfesor", conexiune);

            cmd.Parameters.Add("nume", textBoxNume.Text);
            cmd.Parameters.Add("prenume", textBoxPrenume.Text);
            cmd.Parameters.Add("disciplina", comboBoxdisciplina.Text);
            cmd.Parameters.Add("tipActivitate", comboBoxTip.Text);
            cmd.Parameters.Add("idProfesor",Convert.ToInt32(textBoxId.Text));

            cmd.ExecuteNonQuery();

            cmd2.Parameters.Add("prenume", textBoxPrenume.Text);
            cmd2.Parameters.Add("disciplina", comboBoxdisciplina.Text);
            cmd2.Parameters.Add("idProfesor", Convert.ToInt32(textBoxId.Text));

            cmd2.ExecuteNonQuery();


            MessageBox.Show("Update cu succes");
            this.Hide();


        }

        private void textBoxNume_Click(object sender, EventArgs e)
        {
            textBoxNume.Clear();
        }

        private void textBoxId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxId, "");
        }

        private void textBoxId_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxId.Text.Any(x => char.IsLetter(x)) )
            {
                errorProvider1.SetError(textBoxId, "Format id incorect");
                e.Cancel = true;
            }


        }

        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNume, "");
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNume.Text.Any(x => !char.IsLetter(x)))
            {
                errorProvider1.SetError(textBoxNume, "Nu se accepta cifre");
                e.Cancel = true;
            }
        }

        private void textBoxPrenume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPrenume, "");
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrenume.Text.Any(x => !char.IsLetter(x)))
            {
                errorProvider1.SetError(textBoxPrenume, "Nu se accepta cifre");
                e.Cancel = true;
            }

        }

        private void comboBoxdisciplina_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxdisciplina, "");
        }

        private void comboBoxdisciplina_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxdisciplina.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxdisciplina, "Trebuie introdusa o disciplina!");
                e.Cancel = true;
            }

        }

        private void comboBoxTip_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(comboBoxTip, "");
        }

        private void comboBoxTip_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxTip.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxTip, "Trebuie completat acest camp");
                e.Cancel = true;
            }

        }

        private void textBoxPrenume_Click(object sender, EventArgs e)
        {
            textBoxPrenume.Clear();
        }

        private void buttonAdauga_Validating(object sender, CancelEventArgs e)
        {
           /* if (comboBoxdisciplina.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxdisciplina, "Trebuie completat acest camp");
                e.Cancel = true;
            }*/
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxTip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                buttonAdauga_Click(sender, null);

        }
    }
}

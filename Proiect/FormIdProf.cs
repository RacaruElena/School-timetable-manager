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
    public partial class FormIdProf : Form
    {
        //ListViewItem l;
        FormVizualizare parinte;
        SqlCommand cmd;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Orar;Integrated Security=True";
        public FormIdProf(FormVizualizare parinte2)
        {
            InitializeComponent();
            //this.parinte=parinte;
            //parinte = this.parinte;
            parinte = parinte2;

        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //IncarcaDate();

            SqlConnection conexiune = new SqlConnection(stringConexiune);  //conexiunea stie unde sa identifice server ul de baza de date
            conexiune.Open();
            string sql = "select * from dbo.Orar where IdProfesor='" + Convert.ToInt32(textBoxid.Text) + "'";
           // "SELECT * FROM CURSURI WHERE IDProfesor=" + Convert.ToInt32(textBoxIDProfesor.Text) + "";
            SqlCommand cmd = new SqlCommand(sql, conexiune);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            parinte.dataGridView1.Rows.Clear();
            parinte.dataGridView1.Refresh();
            while (rd.Read())
            {
                Orar orar = new Orar();
                Sala sala = new Sala();
                Profesor profesor = new Profesor();
                orar.sala = sala;
                orar.profesor = profesor;
                orar.ziua = rd.GetString(6).ToString();
                orar.ora = rd.GetString(7).ToString();
                orar.sala.nrSala = rd.GetString(1).ToString();
                //orar.profesor.nume = rd.GetString(3).ToString();
                //orar.profesor.prenume = rd.GetString(4).ToString();
                orar.profesor.nume = rd.GetString(3).ToString();
                orar.profesor.prenume = rd.GetString(4).ToString();
               // orar.Profesor = rd.GetString(3).ToString() + " " + rd.GetString(3).ToString();
                orar.disciplina = rd.GetString(5).ToString();

                parinte.dataGridView1.Rows.Add(orar.ziua.ToString(), orar.ora.ToString(),orar.sala.nrSala.ToString(),orar.profesor.nume.ToString() + " " + orar.profesor.prenume.ToString(), orar.disciplina.ToString());

                
/*                ListViewItem lv = new ListViewItem(orar.ziua);
                lv.SubItems.Add(orar.ora);
                lv.SubItems.Add(orar.Sala);
                lv.SubItems.Add(orar.Profesor);
                lv.SubItems.Add(orar.disciplina);

                parinte.listViewOrar.Items.Add(lv);

                lv.Tag = orar;*/
            }
            this.Hide();
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {
            //textBoxid.Clear();
        }

        private void textBoxid_Click(object sender, EventArgs e)
        {
            textBoxid.Clear();
        }

        private void textBoxid_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxid, "");
        }

        private void textBoxid_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxid.Text.Any(x => char.IsLetter(x)))
            {
                errorProvider1.SetError(textBoxid, "Format id incorect");
                e.Cancel = true;
            }
        }

        private void textBoxid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                buttonCauta_Click(sender, null);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

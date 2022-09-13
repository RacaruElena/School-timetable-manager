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
    public partial class Form1 : Form
    {
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Orar;Integrated Security=True";
        DataSet ds = new DataSet();
        public List<Orar> listaorar;
        //SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            listaorar = new List<Orar>();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            FormOrar fo = new FormOrar();
            fo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizare fv = new FormVizualizare();
            fv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conexiune = new SqlConnection(stringConexiune);  //conexiunea stie unde sa identifice server ul de baza de date
            conexiune.Open();
            string sql = "select * from dbo.Orar";
            SqlCommand cmd = new SqlCommand(sql, conexiune);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            // List<string> linii = File.ReadAllLines(fisier).ToList();
            while (rd.Read())
            {
                Sala s = new Sala();
                Profesor p = new Profesor();
                Orar orar = new Orar();
                orar.sala = s;
                orar.profesor = p;
                orar.sala.nrSala = rd.GetString(1).ToString();
                orar.profesor.nume = rd.GetString(3).ToString();
                orar.profesor.prenume = rd.GetString(4).ToString();
                orar.ziua = rd.GetString(6).ToString();
                listaorar.Add(orar);

            }
            conexiune.Close();

            MessageBox.Show("Date incarcate din baza de date!");
            //Invalidate();
            //panel1.Invalidate();
            FormGrafic fg = new FormGrafic(this);
            fg.Show();
        }


    }
}

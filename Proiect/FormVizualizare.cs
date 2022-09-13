using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace Proiect
{
    public partial class FormVizualizare : Form
    {
        Font printFont;
        Bitmap bitmap;
        ListViewItem lv;
        SqlCommand cmd;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Orar;Integrated Security=True";
        public FormVizualizare()
        {
            InitializeComponent();
        }

        private void completToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare medici(*.txt) | *.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fisier = fd.FileName;
                List<Orar> lista = new List<Orar>();
                List<string> linii = File.ReadAllLines(fisier).ToList();

                foreach (var linie in linii)
                {
                    string[] elem = linie.Split(' ');
                    Orar orarlocal = new Orar();
                    Sala s = new Sala();
                    Profesor p = new Profesor();
                    orarlocal.sala = s;
                    orarlocal.profesor = p;

                    orarlocal.ziua = elem[0];
                    orarlocal.ora = elem[2];
                    orarlocal.sala.nrSala = elem[3];
                    orarlocal.profesor.nume = elem[4];
                    orarlocal.profesor.prenume = elem[5];
                    orarlocal.disciplina = elem[6];


                    lista.Add(orarlocal);
                }
                foreach (var m in lista)
                {

                  dataGridView1.Rows.Add(m.ziua.ToString(), m.ora.ToString(), m.sala.nrSala.ToString(), m.profesor.nume.ToString()+ " " + m.profesor.prenume.ToString(), m.disciplina.ToString());


                }


            }
        }


        private void dupaIdProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIdProf fid = new FormIdProf(this);
            fid.ShowDialog();
            
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(bitmap, 0,0);


        }

        private void printareOrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}

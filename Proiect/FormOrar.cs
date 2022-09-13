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

namespace Proiect
{
    public partial class FormOrar : Form
    {

        ListViewItem l;
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-Orar;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlCommand cmd;
        public TreeNode torar;

        public FormOrar()
        {
            InitializeComponent();



            Sala s1 = new Sala("Sala_2305", 4, 100);
            Sala s2 = new Sala("Sala_2306", 3, 30);
            Sala s3 = new Sala("Sala_2307", 2, 150);
            Sala s4 = new Sala("Sala_2308", 4, 60);
            Sala s5 = new Sala("Sala_2309", 3, 28);
            Sala s6 = new Sala("Sala_2310", 2, 120);


            ListViewItem lv1 = new ListViewItem(s1.nrSala.ToString());
            lv1.SubItems.Add(s1.etaj.ToString());
            lv1.SubItems.Add(s1.nrLocuri.ToString());
            lv1.Tag = s1;

            ListViewItem lv2 = new ListViewItem(s2.nrSala.ToString());
            lv2.SubItems.Add(s2.etaj.ToString());
            lv2.SubItems.Add(s2.nrLocuri.ToString());
            lv2.Tag = s2;

            ListViewItem lv3 = new ListViewItem(s3.nrSala.ToString());
            lv3.SubItems.Add(s3.etaj.ToString());
            lv3.SubItems.Add(s3.nrLocuri.ToString());
            lv3.Tag = s3;

            ListViewItem lv4 = new ListViewItem(s4.nrSala.ToString());
            lv4.SubItems.Add(s4.etaj.ToString());
            lv4.SubItems.Add(s4.nrLocuri.ToString());
            lv4.Tag = s4;
            ListViewItem lv5 = new ListViewItem(s5.nrSala.ToString());
            lv5.SubItems.Add(s5.etaj.ToString());
            lv5.SubItems.Add(s5.nrLocuri.ToString());
            lv5.Tag = s5;
            ListViewItem lv6 = new ListViewItem(s6.nrSala.ToString());
            lv6.SubItems.Add(s6.etaj.ToString());
            lv6.SubItems.Add(s6.nrLocuri.ToString());
            lv6.Tag = s6;

            listView2.Items.Add(lv1);
            listView2.Items.Add(lv2);
            listView2.Items.Add(lv3);
            listView2.Items.Add(lv4);
            listView2.Items.Add(lv5);
            listView2.Items.Add(lv6);

            Profesor p1 = new Profesor(99, "Tudor", "Marcel", "mate", "seminar");
            ListViewItem lp = new ListViewItem(new string[] { p1.idProfesor.ToString(), p1.nume, p1.prenume, p1.disciplina, p1.tipActivitate });
            lp.Tag = p1;
            listView1.Items.Add(lp);


            //incarcare sali in treeview

            TreeNode t1 = treeView1.Nodes.Add(s1.nrSala.ToString()); //am creat nodul si l-am si adaugat in colectie
            t1.Tag = s1;  //daca vreau sa aflu si datele pe care nu le-am pus mai sus

            TreeNode t2 = treeView1.Nodes.Add(s2.nrSala.ToString());
            t2.Tag = s2;

            TreeNode t3 = treeView1.Nodes.Add(s3.nrSala.ToString());
            t3.Tag = s3;

            TreeNode t4 = treeView1.Nodes.Add(s4.nrSala.ToString());
            t4.Tag = s4;

            TreeNode t5 = treeView1.Nodes.Add(s5.nrSala.ToString());
            t5.Tag = s5;

            TreeNode t6 = treeView1.Nodes.Add(s6.nrSala.ToString());
            t6.Tag = s6;


            IncarcaDate();
        }
        public void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);  
            conexiune.Open();
            string sql = "select idProfesor, nume, prenume, disciplina,tipActivitate from Profesori";
            SqlCommand cmd = new SqlCommand(sql, conexiune);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                Profesor prof = new Profesor();
                prof.idProfesor = rd.GetInt32(0);
                prof.nume = rd.GetString(1).ToString();
                prof.prenume = rd.GetString(2).ToString();
                prof.disciplina = rd.GetString(3).ToString();
                prof.tipActivitate = rd.GetString(4).ToString();


                ListViewItem lv = new ListViewItem(prof.idProfesor.ToString());
                lv.SubItems.Add(prof.nume);
                lv.SubItems.Add(prof.prenume);
                lv.SubItems.Add(prof.disciplina);
                lv.SubItems.Add(prof.tipActivitate);

                listView1.Items.Add(lv);

                lv.Tag = prof;

            }



        }
        public void SalveazaDate()
        {
            SaveFileDialog fd = new SaveFileDialog();

            fd.CheckPathExists = true;
            fd.Filter = "fisiere text medici (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fisier = fd.FileName;
                StreamWriter sw = new StreamWriter(fisier);

                SqlConnection conexiune = new SqlConnection(stringConexiune);  //conexiunea stie unde sa identifice server ul de baza de date
                conexiune.Open();
                string sql = "select * from dbo.Orar order by Ziua";
                SqlCommand cmd = new SqlCommand(sql, conexiune);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {


                    sw.Write(rd.GetInt32(0) + " ");

                    sw.Write(rd.GetString(6).ToString() + " ");
                    sw.Write(rd.GetString(7).ToString() + " ");
                    sw.Write(rd.GetString(1).ToString() + " ");
                    sw.Write(rd.GetString(3).ToString() + " ");
                    sw.Write(rd.GetString(4).ToString() + " ");
                    sw.Write(rd.GetString(5).ToString());



                    sw.WriteLine();

                }
                sw.Close();
                MessageBox.Show("Salvat in fisierul: " + fisier);
            }

        }


        private void modificaProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesor fp = new FormProfesor(this);


            fp.textBoxId.Text = listView1.SelectedItems[0].Text;
            fp.textBoxNume.Text = listView1.SelectedItems[0].SubItems[1].Text;
            fp.textBoxPrenume.Text = listView1.SelectedItems[0].SubItems[2].Text;
            fp.comboBoxdisciplina.Text = listView1.SelectedItems[0].SubItems[3].Text;
            fp.comboBoxTip.Text = listView1.SelectedItems[0].SubItems[4].Text;
            fp.buttonAdauga.Hide();
            fp.textBoxId.Enabled = false;
            fp.ShowDialog();
            

            IncarcaDate();

        }

        private void stergeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            cmd = new SqlCommand("delete from dbo.Profesori where idProfesor='" + listView1.SelectedItems[0].Text + "'", conexiune);
            SqlCommand cmd2 = new SqlCommand("delete from dbo.Orar where idProfesor='" + listView1.SelectedItems[0].Text + "'", conexiune);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();


            MessageBox.Show("delete cu succes");
            IncarcaDate();

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var fi = listView1.FocusedItem;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))   //verificam ce am primit in aceasta operatie de drag and drop
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)  //daca avem item selectat in lista profesori
            {
                listView1.DoDragDrop(listView1.SelectedItems[0], DragDropEffects.Copy);

            }
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            //aici stim ca avem un listviewitem in DragEventArgs

            Point px = new Point(listView2.PointToClient(new Point(e.X, e.Y)).Y, listView1.PointToClient(new Point(e.X, e.Y)).X);
            ListViewItem lv = listView2.GetItemAt(px.Y, px.X);      //preluam listviewitem-ul pe care s-a ridicat butonul stanga mouse, dar inainte treb sa vedem care sunt coordonatele
            if (lv != null)
            {
                Profesor p = (Profesor)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag; //getData da un obiect caruia ii facem cast la listviewitem
                                                                                                 //acum stim ce sala, ce prof si facem orar

                Orar orar = new Orar((Sala)lv.Tag, p);

                List<TreeNode> listanoduri = treeView1.Nodes.Cast<TreeNode>().ToList();

                TreeNode nodorar = listanoduri.Find(s => ((Sala)s.Tag).nrSala == orar.sala.nrSala);  //am identificat sala 


                torar = nodorar.Nodes.Add(orar.profesor.nume + " " + orar.profesor.prenume + " " + orar.profesor.disciplina);
                torar.Tag = orar;

                FormDetalii fd = new FormDetalii(torar);
                fd.ShowDialog();
                nodorar.Expand();

                SqlConnection conexiune = new SqlConnection(stringConexiune);
                conexiune.Open();

                cmd = new SqlCommand("insert into dbo.Orar values('" + orar.sala.nrSala + "','" + orar.profesor.idProfesor + "','" + orar.profesor.nume + "','" + orar.profesor.prenume + "','" + orar.profesor.disciplina + "','" + fd.comboBoxZiua.Text + "','" + fd.comboBoxora.Text + "')", conexiune);
                cmd.ExecuteNonQuery();
            }

        }



        private void buttonOrar_Click(object sender, EventArgs e)
        {
            FormVizualizare fv = new FormVizualizare();
            fv.Show();

        }

        private void salveazaInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalveazaDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfesor fp = new FormProfesor(this);
            fp.buttonActualizeaza.Hide();
            fp.ShowDialog();


            IncarcaDate();

        }
    }
}

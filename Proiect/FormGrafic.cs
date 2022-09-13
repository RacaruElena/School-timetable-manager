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
    public partial class FormGrafic : Form
    {
        Form1 fgrafic;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        public FormGrafic(Form1 parinte)
        {
            InitializeComponent();
            fgrafic = parinte;
        }

        public void deseneaza()
        {
            panel1.Invalidate(); //ii spune ca zona panel ului nu mai e de actualitate

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int nrLuni = 0;
            int nrMarti = 0;
            int nrMiercuri = 0;
            int nrJoi = 0;
            int nrVineri = 0;

            int[] nrore=new int[5];
            Graphics g = e.Graphics;
            SolidBrush[] pensule = new SolidBrush[]
           {
                new SolidBrush(Color.GreenYellow),
                new SolidBrush(Color.Aquamarine),
                new SolidBrush(Color.Moccasin),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.LightCoral),
                new SolidBrush(Color.DarkSeaGreen)
           };
            Pen[] creioane = new Pen[]
          {
                new Pen(Color.Red),
                new Pen(Color.Blue),
                new Pen(Color.Green),
                new Pen(Color.DarkViolet),
                new Pen(Color.Cyan),
                new Pen(Color.Olive)
          };
            SolidBrush pensula_curenta;
            Pen creion_curent;
            foreach (Orar orar in fgrafic.listaorar)
            {
                if (string.Equals(orar.ziua, "Luni"))
                {
                    nrLuni++;
                   

                }
                else if (string.Equals(orar.ziua, "Marti"))
                {
                    nrMarti++;

                }
                else if (string.Equals(orar.ziua, "Miercuri"))
                {
                    nrMiercuri++;

                }
                else if (string.Equals(orar.ziua, "Joi"))
                {
                    nrJoi++;

                }
                else if (string.Equals(orar.ziua, "Vineri"))
                {
                    nrVineri++;

                }
                nrore[0] = nrLuni;
                nrore[1]= nrMarti;
                nrore[2] = nrMiercuri;
                nrore[3] = nrJoi;
                nrore[4] = nrVineri;
                
            }
            creion_curent = creioane[1];
            Rectangle[] recs = new Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                pensula_curenta = pensule[(4 + i) % 6];
                double latime = recs[i].Width / 5 / 3;
                recs[i] = new Rectangle(5, 5 + i * 50, 200 * nrore[i] / nrore.Max(), 40);
                g.DrawRectangle(creion_curent, recs[i]);
                g.FillRectangle(pensula_curenta, recs[i]);
                g.DrawString(nrore[i].ToString(), font, new SolidBrush(Color.Black), 5, 5 + i * 50);


            }
 
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}

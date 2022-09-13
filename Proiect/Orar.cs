using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Orar
    {
        public Profesor profesor;
        public Sala sala;
        public string disciplina;
        public string ora;
        public string ziua;

        public Orar(Sala s, Profesor p)
        {
            profesor = p;
            sala = s;
        }
        public Orar()
        {

        }

    }
}

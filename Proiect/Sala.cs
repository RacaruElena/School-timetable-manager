using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Sala
    {
        public string nrSala;
        public int etaj;
        public int nrLocuri;
        public Sala(string _nrSala,int _etaj,int _nrLocuri)
        {
            nrSala = _nrSala;
            etaj = _etaj;
            nrLocuri = _nrLocuri;
        }
        public Sala()
        {

        }
    }
}

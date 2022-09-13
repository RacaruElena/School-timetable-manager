using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Profesor
    {
        public int idProfesor;
        public string nume;
        public string prenume;
        public string disciplina;
        public string tipActivitate;
        public Profesor(int _idProfesor, string _nume,string _prenume, string _denumire, string _tipActivitate)
        {
            idProfesor = _idProfesor;
            nume = _nume;
            prenume = _prenume;
            disciplina = _denumire;
            tipActivitate = _tipActivitate;
        }
        public Profesor()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernabe.mattia._4j.contagi.models
{
    class ContagiRimini
    {
        public string Data;
        public int Progressivo;
        public int Contagi;
        public ContagiRimini()
        {

        }
        public ContagiRimini(string d, int p, int c)
        {
            Data = d;
            Progressivo = p;
            Contagi = c;
        }
    }
}

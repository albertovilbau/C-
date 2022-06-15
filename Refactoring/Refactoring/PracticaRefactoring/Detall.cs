using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRefactoring
{
    public class Detall
    {
        private double preu1;
        private int quantitat1;
        private string producte;

        public string Producte { get => producte; set => producte = value; }
        public int quantitat { get => quantitat1; set => quantitat1 = value; }
        public double preu { get => preu1; set => preu1 = value; }
    }
}

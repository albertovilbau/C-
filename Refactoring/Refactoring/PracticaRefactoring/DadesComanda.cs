using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRefactoring
{
    public class DadesComanda
    {
        private string importBrut;
        private string iVA;
        private string despesa;
        private string descompte;
        private string numComanda;
        private string client;
        private string estat;

        public string ImportBrut { get => importBrut; set => importBrut = value; }
        public string IVA { get => iVA; set => iVA = value; }
        public string Despesa { get => despesa; set => despesa = value; }
        public string Descompte { get => descompte; set => descompte = value; }
        public string NumComanda { get => numComanda; set => numComanda = value; }
        public string Client { get => client; set => client = value; }
        public string Estat { get => estat; set => estat = value; }

    }
}

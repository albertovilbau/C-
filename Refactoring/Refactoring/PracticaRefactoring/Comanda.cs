using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRefactoring
{
    class Comanda
    {

        private const double iva = 0.21;

        public double CalcularImportBrut(List<Detall> linia)
        {
            double importBrut = 0.0;
            foreach (Detall lin in linia)
            {
                importBrut = importBrut + (lin.quantitat * lin.preu);
            }

            return importBrut;
        }

        public double Despesa(List<Detall> linia, string client){

            double despesa = 0.0;
            double importBrut = CalcularImportBrut(linia);

            if (client.EndsWith("A") || client.EndsWith("B"))
            {
                if (importBrut > 500 || client.EndsWith("A"))
                {
                    despesa = 0.0;
                }
                else
                {
                    despesa = 5.0;
                }
            }
            else if (client.EndsWith("C"))
            {
                despesa = importBrut * 0.03;
                if (despesa > 10)
                    despesa = 10;
            }
            
            return despesa;

        }

        public double Descompte(List<Detall> linia, string client)
        {
            double importBrut = CalcularImportBrut(linia);
            double descompte = 0.0;
                        
            if (client.EndsWith("A"))
            {
                descompte = importBrut * 0.05;
            }
            if (client.EndsWith("B"))
            {
                descompte = importBrut * 0.03;
            }
            if (client.EndsWith("C"))
            {
                descompte = importBrut * 0.01;
            }
            return descompte;
        }

        public double Iva(List<Detall> linia)
        {
            double importBrut = CalcularImportBrut(linia);
            double calculariva = importBrut * iva;
            return calculariva;
        }

        public double Total(List<Detall> linia, string client)
        {
            double importNet;
            double importBrut = CalcularImportBrut(linia);
            double despesa = Despesa(linia, client);
            double preuiva = Iva(linia);
            double descompte = Descompte(linia,client);

            importNet = importBrut + preuiva + despesa - descompte;
            return importNet;
        }
    }
}

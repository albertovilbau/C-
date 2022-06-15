using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Calculo
    {
        //Generar MCD
        public int generarMCD(int longui, int lat)
        {
            int numMCD;

            do
            {
                numMCD = longui;

                longui = lat % longui;

                lat = numMCD;

            } while (longui != 0);

            return numMCD;
        }

        //Generar MCM
        public int generarMCM(int longui, int lat)
        {
            double numMCM = 0;

            numMCM = (lat / generarMCD(lat, longui)) * longui;

            return Convert.ToInt32(numMCM);
        }

        //Calcular
        public List<int> Calculs(int numMCD, int numMCM)
        {
            List<int> res = new List<int>();

            int multi = numMCD * numMCM;

            if (multi <= 300)
            {
                int Suma = numMCD + numMCM;
                res.Add(Suma);
                int PrimeraResta = numMCD - numMCM;
                res.Add(PrimeraResta);
                int SegonaResta = numMCM - numMCD;
                res.Add(SegonaResta);
                res.Add(multi);
                double PrimeraDivisio = Convert.ToDouble(numMCD) / Convert.ToDouble(numMCM);
                res.Add(Convert.ToInt32(PrimeraDivisio));
                double SegonaDivisio = Convert.ToDouble(numMCM) / Convert.ToDouble(numMCD);
                res.Add(Convert.ToInt32(SegonaDivisio));
            }

            return res;
        }

        //Calcular longitud en la tabla
        public int CalculoLongitudGrid(List<int> calculos)
        {
            int longui = 0;

            for (int i = 0; i < 3; i++)
            {
                longui = +calculos[i];
            }

            longui = longui % 6;

            return longui;
        }

        //Calcular latitud en la tabla
        public int CalculoLatitudGrid(List<int> calculos)
        {
            double lat = 0;

            for (int i = 3; i < 6; i++)
            {
                lat = +calculos[i];
            }

            lat = (lat % 5) + 1;

            return Convert.ToInt32(lat);
        }


    }
}


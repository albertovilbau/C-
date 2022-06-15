using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs
{
    public class Despesa
    {
        public double CalculaDespesa(int import)
        {
            if (import<101)
            {
                return import * 0.05;
            }
            else
            {
                return 6;
            }
        }
    }
}

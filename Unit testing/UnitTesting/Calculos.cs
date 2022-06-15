using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting
{
    public class Calculos
    {
        public int maximcomundivisor(int num1, int num2)
        {

            try
            {
                int remanent;

                while (num2 != 0)
                {
                    remanent = num1 % num2;
                    num1 = num2;
                    num2 = remanent;
                }

                return num1;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Can not divide by zero");
                return 0;
            }
        }

        public int MCMCalculus(int a, int b)
        {
            
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
            
        }

        public int minimocomunmultiple(int a, int b)
        {
            try
            {
                return (a / MCMCalculus(a, b)) * b;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Can not divide by zero");
                return 0;
            }
        }

        public List<int> Calculus(int num1, int num2)
        {
            List<int> resultado = new List<int>();
            try
            {
            
                resultado.Add(num1 + num2);
                resultado.Add(num1 - num2);
                resultado.Add(num2 - num1);
                resultado.Add(num1 * num2);
                resultado.Add(Convert.ToInt32(num1 / num2));
                resultado.Add(Convert.ToInt32(num2 / num1));

                return resultado;

            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("Error a l' hora de dividir per 0");
                resultado.Clear();
                return resultado;
               
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculs;

namespace Calcul.UniTest
{

    [TestFixture]
    public class DespesaTest
    {

        [TestCase(5,0.25)]
        [TestCase(45,2.25)]
        [TestCase(452,6)]
        [TestCase(100, 5)]
        [TestCase(101, 6)]
        public void calculdespesa_calcul_expectedresoult(int import, double resultat)
        {
            //Arrange
            var calc = new Despesa();

            //Act
            double res = calc.CalculaDespesa(import);

            //Assert
            Assert.That(res, Is.EqualTo(resultat));

        }

    }
}

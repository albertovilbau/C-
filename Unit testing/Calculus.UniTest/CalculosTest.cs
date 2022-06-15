using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;
using NUnit.Framework;

namespace Calculus.UniTest
{

    [TestFixture]
    public class CalculosTest
    {

        [TestCase(5,3,1)]
        [TestCase(8,34,2)]
        [TestCase(3,15,3)]
        public void maximcomundivisor_calculos_expectedresoult(int num1, int num2, int resoult)
        {

            //Arrange
            var calc = new Calculos();

            //Act
            var result = calc.maximcomundivisor(num1, num2);

            //Asert
            Assert.That(result, Is.EqualTo(resoult));

        }

        [TestCase(5,24,120)]
        [TestCase(7,3,21)]
        [TestCase(1,30,30)]
        public void minimocomunmultiple_calculos_expectedresoult(int num1, int num2, int resoult)
        {

            //Arrange
            var calc = new Calculos();

            //Act
            var result = calc.minimocomunmultiple(num1, num2);

            //Asert
            Assert.That(result, Is.EqualTo(resoult));

        }

        [TestCase(4, 21)]

        public void Calculus_calculolista_expectedreoult(int num1, int num2)
        {
            //Arrange
            var calc = new Calculos();
            List<int> test1 = new List<int> { 25, -17, 17, 84, 0, 5 };

            //Act
            var result = calc.Calculus(num1, num2);

            //Asert
            Assert.That(result, Is.EqualTo(test1));

        }

    }
}

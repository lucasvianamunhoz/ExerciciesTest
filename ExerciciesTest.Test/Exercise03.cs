using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciesTest.Console.Implementation;
using ExerciciesTest.Console.Interfaces;
using Moq;
using NUnit.Framework;

namespace ExerciciesTest.Test
{
    public  class Exercise03
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void FormatWords_Success_Without_Space_Null()
        {
            // arrange
            var lista = new string[] {"ninja", "samurai", "ronin"};

            var mock = new Mock<Ex03>();
            var ex03 = new Ex03();

            // act
            var resultadoEsperado = mock.Object.FormatedWords(lista.ToArray());
            var resultado = ex03.FormatedWords(lista.ToArray());

            // assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [Test]
        public void FormatWords_Success_With_Space_Null()
        {
            // arrange
            var lista = new string[] { "ninja", "samurai",null,"", "ronin" };

            var mock = new Mock<Ex03>();
            var ex03 = new Ex03();

            // act
            var resultadoEsperado = mock.Object.FormatedWords(lista.ToArray());
            var resultado = ex03.FormatedWords(lista.ToArray());

            // assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}

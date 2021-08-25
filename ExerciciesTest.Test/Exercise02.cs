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
    public  class Exercise02
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ReturnInt()
        {
            // arrange
            var lista = new List<object>(){1, 2, "a", "b", 0, 15};

            var mock = new Mock<Ex02>();
            var retorno = new  object[] {1, 2, 0, 15};


            var ex02 = new Ex02();

            // act
            var resultadoEsperado = mock.Object.RemoveString(lista.ToArray());
            var resultado = ex02.RemoveString(lista.ToArray());

            // assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}

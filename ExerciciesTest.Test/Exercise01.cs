using System.Collections.Generic;
using ExerciciesTest.Console.Implementation;
using ExerciciesTest.Console.Interfaces;

using Moq;
using NUnit.Framework;

namespace ExerciciesTest.Test
{
    public class Exercise01
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OddNumber()
        {
            // arrange
            var odd = new int[]
            {
                2, 4, 0, 100, 4, 11, 2602, 36
            };

            var mock = new Mock<IEx01>();
            var number = 0;
            mock.Setup(m => m.FindOutlier(odd)).Returns(11);
            var ex01 = new Ex01();
            
            // act
            var resultadoEsperado  = mock.Object.FindOutlier(odd);
            var resultado = ex01.FindOutlier(odd);

            // assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [Test]
        public void EvenNumber()
        {
            // arrange
            var odd = new int[]
            {
                160, 3, 1719, 19, 11, 13, -21
            };

            var mock = new Mock<IEx01>();
            var number = 0;
            mock.Setup(m => m.FindOutlier(odd)).Returns(160);
            var ex01 = new Ex01();

            // act
            var resultadoEsperado = mock.Object.FindOutlier(odd);
            var resultado = ex01.FindOutlier(odd);

            // assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
        [Test]
        public void NotFindNumber_Error()
        {
            // arrange
            var odd = new int[]
            {
                160, 3, 1719, 19, 11, 13, -21
            };

            var mock = new Mock<IEx01>();
            var number = 0;
            mock.Setup(m => m.FindOutlier(odd)).Returns(3);
            var ex01 = new Ex01();

            // act
            var resultadoEsperado = mock.Object.FindOutlier(odd);
            var resultado = ex01.FindOutlier(odd);

            // assert
            Assert.AreNotEqual(resultado, resultadoEsperado);
        }
    }
}
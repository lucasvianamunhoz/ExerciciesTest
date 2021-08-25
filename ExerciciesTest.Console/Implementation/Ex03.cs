using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciesTest.Console.Interfaces;

namespace ExerciciesTest.Console.Implementation
{
    public class Ex03:IEx03
    {
        public string FormatedWords(string[] numbers)
        {
            var lista = numbers.Where(a => a != null && a != "").ToList();
            return string.Join(" and ", lista.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciesTest.Console.Interfaces;

namespace ExerciciesTest.Console.Implementation
{
    public class Ex02:IEx02
    {
        public object[] RemoveString(object[] numbers)
        {
            var list = numbers.ToList().Where(a=>a.GetType()==typeof(int)).ToList();
            return list.ToArray();

        }
    }
}

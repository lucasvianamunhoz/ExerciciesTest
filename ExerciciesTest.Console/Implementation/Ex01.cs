using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciesTest.Console.Interfaces;

namespace ExerciciesTest.Console.Implementation
{
    public class Ex01:IEx01
    {
        public int FindOutlier(int[] numbers)
        {
            var even = numbers.Where(a => a % 2==0);
            var odd = numbers.Where(a =>  a % 2!=0);
            return even.Count() == 1 ? even.FirstOrDefault() : odd.FirstOrDefault();
        }
    }
}

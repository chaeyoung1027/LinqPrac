using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            //Linq없이 2의 배수 구하기
            foreach (int i in input)
            {
                if(i%2==0) output.Add(i);
            }
            foreach(var i in output)
            {
                Console.WriteLine(i);
            }
            var output2 = from item in input
                          where item % 2 == 0
                          orderby item descending
                          select item * item;
            foreach (var i in output2)
            {
                Console.WriteLine(i);
            }
            output = output2.ToList<int>();
            int[] output3 = output2.ToArray<int>();
        }
    }
}

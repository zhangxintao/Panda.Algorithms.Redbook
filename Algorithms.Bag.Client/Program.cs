using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Bag.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new PandaBag<double>();

            var input = string.Empty; 
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                numbers.Add(Convert.ToDouble(input));
            }

            var size = numbers.Size();

            var sum = 0.0;
            foreach (var x in numbers)
            {
                sum += x;
            }

            var mean = sum/size;

            sum = 0.0;
            foreach (var x in numbers)
            {
                sum += (x - mean)*(x - mean);
            }
            var std = Math.Sqrt(sum/(size - 1));

            Console.WriteLine("Mean: {0}", mean);
            Console.WriteLine("Std dev: {0}", std);
        }
    }
}

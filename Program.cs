using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 30;
            Console.WriteLine("Enter first Value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first == c || second == c || first + second == 30)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }

        }
    }
}

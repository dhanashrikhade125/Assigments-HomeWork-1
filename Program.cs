using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");
            Console.WriteLine("5. Mod");
            Console.WriteLine("Select option from 1-5");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of B");
            int B = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Add=" + (A + B));
                    break;
                case 2:
                    Console.WriteLine("Sub=" + (A - B));
                    break;
                case 3:
                    Console.WriteLine("Mul=" + (A * B));
                    break;
                case 4:
                    Console.WriteLine("Div=" + (A / B));
                    break;
                case 5:
                    Console.WriteLine("Mod=" + (A % B));
                    break;
                default:
                    Console.WriteLine(" you have selected wrong option");
                    break;
            }
        }
    }
}

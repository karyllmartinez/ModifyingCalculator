using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //An error message when the user tries to enter decimal values.
            //A third operand for the calculator.
            //An error message when the user tries to enter any string value other than “exit”.
            do
            {
                Console.WriteLine("Modifying Calculator");
                Console.WriteLine("Type exit to stop the program");
                Console.WriteLine("==============================");
                Console.Write("x = ");
                string str = Console.ReadLine();
                int num;
                if (str == "exit")
                {
                    Console.WriteLine("Program has stopped");
                    break;
                }
                else if (!int.TryParse(str, out num))
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("==============================");
                }
                else
                {
                    int x = Convert.ToInt32(str);
                    Console.Write("y = ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("z = ");
                    int z = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y + z;
                    int num2 = 0;
                    Console.WriteLine("Result: {0}", sum);
                    Console.WriteLine("==============================");

                }


            }
            while (true);
        }
    }
}

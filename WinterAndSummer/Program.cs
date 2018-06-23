using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterAndSummer
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            do
            {
                Console.Clear();
                Console.WriteLine("Enter temperature values separated by spaces");
                var input = Console.ReadLine().Split(' ');
                var temperaturesArray = new int[input.Length];
                for(int i = 0; i < input.Length; i++)
                {
                    if (!int.TryParse(input[i], out int temperature))
                    {
                        Console.WriteLine("Please check the input and try again.");
                        Console.ReadKey();
                        return;
                    }
                    temperaturesArray[i] = temperature;
                }
                var result = solution.WinterAndSummer(temperaturesArray);
                Console.WriteLine(result);
                Console.Write("Repeat? (y/n)");

            } while (ShouldRepeat());
        }

        static bool ShouldRepeat()
        {
            return Console.ReadKey(false).Key == ConsoleKey.Y;
        }
    }
}

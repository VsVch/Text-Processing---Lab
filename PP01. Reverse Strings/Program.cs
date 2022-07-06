using System;
using System.Linq;

namespace PP01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string inputReverse = new string(input.Reverse().ToArray());
                Console.WriteLine($"{input} = {inputReverse}");
                input = Console.ReadLine();
            }
            

        }
    }
}

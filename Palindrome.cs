using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string temp = "";
            Console.WriteLine("Enter any word to check Palindrome ");
            input = Console.ReadLine();
            input = input.ToLower();
            int length = input.Length;

            for (int i = length-1; i >= 0; i--)
            {
                temp += input[i];
            }

            if (input == temp)
            {
                Console.WriteLine(input+" Is a Palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(input+" Is not a Palindrome");
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InterleavingStringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the objects 'letters' and 'numbers'
            string letters;
            string numbers;

            // prompt the user to enter some letters and assigning the object 'letters' with the user's input
            Console.WriteLine("Please enter some letters: ");
            letters = Console.ReadLine();
            
            // showing the user the letters that were input 
            Console.WriteLine("The letters you entered were: " + letters);

            // prompt the user to enter some numbers and assigning the object 'numbers' with the user's input and converting them to a string
            Console.WriteLine("Please enter some numbers: ");
            numbers = Console.ReadLine().ToString();

            // showing the user the numbers that were input
            Console.WriteLine("The numbers you entered were: " + numbers);
            

            int i = 0;

            // foreach loop takes each character in letters and numbers and interleaves them, creating one string
            foreach (char character in letters)
            {
                numbers = numbers.Insert(i, character.ToString());
                i = i + 2;
            }

            // wait one second before presenting user with the interleaved string
            Thread.Sleep(1000);

            Console.WriteLine("The interleaved string result is...");

            Thread.Sleep(1000);

            Console.WriteLine(numbers);
            Console.ReadLine();
        }
    }
}

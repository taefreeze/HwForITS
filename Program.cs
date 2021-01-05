using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace man
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersInput = new List<string>();

            Console.WriteLine("Please enter an integer");
            string input = Console.ReadLine();
            numbersInput.Add(input);
            while (input != "")
            {
                Console.WriteLine("Please enter another integer: ");
                input = Console.ReadLine();
                numbersInput.Add(input);
            }

            if (input == "")
            {
                foreach (string value in numbersInput)
                {
                    Console.WriteLine("The number that was added to the list is : " + " " + value);
                }
                Console.ReadLine();
            }
        }
    }
}

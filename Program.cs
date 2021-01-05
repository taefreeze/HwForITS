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
            List<string> Weight = new List<string>();
            int number = 0;

            Console.WriteLine("Please enter an integer");
            string input = Console.ReadLine();
            Weight.Add(input);
            while (input != "")
            {
                Console.WriteLine("Please enter another integer: ");
                input = Console.ReadLine();
                Weight.Add(input);
                number += 1;
            }

            if (input == "")
            {
                foreach (string value in Weight)
                {
                    Console.WriteLine(value);
                }
                Console.ReadLine();
            }
            var DecendingOrder = Weight.OrderByDescending(i => i);
            foreach(string dinosaur in DecendingOrder)
            {
            Console.WriteLine(dinosaur);
            }
        }
    }
}

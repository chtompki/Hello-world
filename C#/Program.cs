using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
           string answer= "";

            while (answer != Convert.ToString(1))
            {
                Console.Write("Choose \'A\' or \'B'; enter 1 to quit: ");
                answer = Console.ReadLine().ToUpper();
                if (answer == "A")
                {
                    Console.WriteLine("\nHello World\n\n");
                }

                else if (answer == "B")
                {
                    Console.WriteLine("\nYou should pick \'A\'\n\n");
                }

                else if (answer == Convert.ToString(1))
                {

                    return;
                }

                else
                {
                    Console.WriteLine("\nThat's not an option\n\n");

                }
                
            }
            
            Console.Write("Choose \'A\' or \'B'; enter 1 to quit: ");
            answer = Console.ReadLine().ToUpper();
        }
    }
}

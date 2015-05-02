using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();

                Console.WriteLine("Hello, {0}!!", name);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured. Message: {0}", ex.Message);
            }

            Console.ReadKey(true);
        }
    }
}

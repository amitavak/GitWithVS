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
                Console.WriteLine("Hello, GIT!!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured. Message: {0}", ex.Message);
            }

            Console.ReadKey(true);
        }
    }
}

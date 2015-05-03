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
                Person person = new Person
                {
                    Name = "Sagar Kshetri",
                    Age = 26
                };

                //Display person name
                Console.WriteLine("Hello, {0}!!", person.Name);

                //Display person's age
                Console.WriteLine("You are {0} years old.", person.Age);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured. Message: {0}", ex.Message);
            }

            Console.ReadKey(true);
        }
    }
}

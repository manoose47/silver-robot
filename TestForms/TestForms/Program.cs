using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have the properties been defined yet?");
            Console.ReadLine();

            DataModel dm = new DataModel();

            // dm.Example = "The property has been set";

            if (dm.Example == null)
            {
                Console.WriteLine("The properties haven't been set.");
            }
            else
            {
                Console.WriteLine(dm.Example);
            }

            Console.ReadLine();

        }

        
    }
}

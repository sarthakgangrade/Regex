using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine("Name: " + patterns.validateName("Mar"));
            Console.WriteLine("LastName: " + patterns.validateLastName("Roy"));
            
            Console.ReadLine();
        }
    }
}

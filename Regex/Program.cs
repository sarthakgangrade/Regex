﻿using System;
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
            Console.WriteLine("Email: " + patterns.validateEmail("sarthakgangrade0@gmail.com"));
            //Console.WriteLine("MobileNumber: " + patterns.validateMobileNumber("91 9784564578"));
            Console.ReadLine();
        }
    }
}

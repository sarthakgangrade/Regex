using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class Patterns
    {
        public static string Regex_Name = "^[A-Z]{1}[A-Z a-z]{2,}$";

        public bool validateName(string Name)
        {
            return Regex.IsMatch(Name, Regex_Name);
        }
    }
}

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
        public static string Regex_MobileNumber = "^[1-9]{2}[ ]{1}[1-9]{1}[0-9]{9}$";
        public static string Regex_Email = "^([A-Za-z0-9]+[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        //rule 1 = min 8 charactors in password
        // public static string Regex_Password = "^[A-Za-z0-9]{8,}$";

        //rule 2 = min  1 uppercase
        //public static string Regex_Password = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        //rule 3 = at least 1 numeric value
        //public static string Regex_Password = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        //rule 4 = one special charactor
        public static string Regex_Password = "^(?=.*[!@#$%^&*])(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9!@#$%^&*]{8,}$";
        public bool validateName(string Name)
        {
            return Regex.IsMatch(Name, Regex_Name);
        }
        public bool validateLastName(string Name)
        {
            return Regex.IsMatch(Name, Regex_Name);
        }
        
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool validateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);
        }

        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }

    }
}

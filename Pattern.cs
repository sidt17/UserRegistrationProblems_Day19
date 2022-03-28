using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexDemo
{
    public class Pattern
    {
        public static string RegexPattern = "^[a-zA-Z]+[.]{0,1}[a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-z]{2}){0,1}$";


        public bool ValidateEmail(string ValidEmail)
        {
            return Regex.IsMatch(ValidEmail, RegexPattern);
        }
    } 
}

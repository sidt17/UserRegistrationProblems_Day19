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
        public static string RegexPattern = "^[A-Z]{1}[A-Z a-z]{2,}$";
     
        public bool ValidateLastname(string LastName)
        {
            return Regex.IsMatch(LastName, RegexPattern);
        }
    } 
}

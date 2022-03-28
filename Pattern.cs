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
        public static string RegexPattern = "^[a-zA-Z0-9]{8,}$";


        public bool ValidateMobileFormat(string password)
        {
            return Regex.IsMatch(password, RegexPattern);
        }
    } 
}

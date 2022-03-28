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
        public static string RegexPattern = "(?=.*?[A-Z])(?=.*?[0-9]).{8,}";



        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, RegexPattern);
        }
    } 
}

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
        public static string RegexPattern = "^[A-Z]{1}[A-Z a-z]{7}$";

        public bool Validatefirstname(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexPattern);
        }
    }
}

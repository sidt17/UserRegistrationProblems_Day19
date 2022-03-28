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
        public static string RegexPattern = "^91[' '][7-9]{1}[0-9]{9}$";


        public bool ValidateMobileFormat(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, RegexPattern);
        }
    } 
}

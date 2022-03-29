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
        public static string RegexPattern = "(?=.*?[A-Z]{0,1})+[.]{0,1}(?=.*?[0-9]{0,1})(?=.*?[@-])";



        public bool ValidateEmailSample(string EmailSample)
        {
            return Regex.IsMatch(EmailSample, RegexPattern);
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ukupholisa
{
    public class Validation
    {
        public bool validateAddress(string address)
        {
            if (!Regex.Match(address, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                // address was incorrect
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validateStrings(string input)
        {
            if (!Regex.Match(input, @"^[A-Z][a-z]*").Success)
            {
                if (!Regex.Match(input, @"^([A-Z][a-zA-Z]{2,}\s[A-Z][a-zA-Z]{1,}'?-?[A-Z][a-zA-Z]{2,}\s?([A-Z][a-zA-Z]{1,})?)").Success) // ^[A-Z][a-z]*(\s[A-Z][a-z]*)+$
                {
                    // incorrect input
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool validatePhone(string phone)
        {
            if (!Regex.Match(phone, @"^[0]{1}[0-9]{9}$").Success)
            {
                // phone number was incorrect
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MedvalidateStrings(string input)
        {
            if (!Regex.Match(input, "^[a-zA-Z]{1,50}$").Success)
            {
                // Medical condition name was incorrect
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

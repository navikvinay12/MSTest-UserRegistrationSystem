﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDay20Assignment
{
    public class UserDetails
    {
        public static bool FirstName(string userInput)      
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
        public static bool LastName(string userInput)
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";  ////UC2 LastName starts with cap and has min 3 char.
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
                return true;
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
                return false;
            }
        }
    }
}
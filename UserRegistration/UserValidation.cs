using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public static string  FIRST_NAME_REGEX = "^[A-Z]+[A-Za-z]{3,}$";
        public static string LAST_NAME_REGEX = "^[A-Z]+[A-Za-z]{3,}$";
        public static string MOBILE_REGEX = "^[7-9]{1,1}[0-9]{9}";
        public static string EMAIL_REGEX = "^[a-z0-9]+[.+_-]?[0-9a-z]+@[a-z0-9]+\\.[a-z]{2,4}([.][a-z]{2,3})?$";
        public static string PASSWORD_REEGX = "((?=.*[a-z])(?=.*\\d)(?=.*[A-Z])(?=.*[@#$%!]).{8,40})";
        public bool ValidateFirstName(string fname)
        {
            return Regex.IsMatch(fname , FIRST_NAME_REGEX);
        }
        public bool ValidateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);
        }

        public bool ValidateMobileNo(string mobile)
        {
            return Regex.IsMatch(mobile, MOBILE_REGEX);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD_REEGX);
        }
    }
}


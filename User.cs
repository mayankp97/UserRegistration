using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        public string firstName { get; set; }
        private string _regexFirstName = "^[A-Z][a-z]{2,}$";
        public string lastName { get; set; }
        private string _regexLastName = "";

        public string email { get; set;  }
        private string _regexEmail = "";

        public string password { get; set; }
        private string _regexPassword = "";

        public string mobileNumber { get; set; }
        private string _regexMobileNumber = "";


        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }

        
    }
}

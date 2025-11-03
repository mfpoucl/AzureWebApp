

using System.Text.RegularExpressions;

namespace DomainPrimitives
{

    public class FirstName
    {
        private string firstName;

        public FirstName(string firstName)
        {
            
            IsFirstNameValidLength(firstName);
            IsFirstNameValidRegex(firstName);
            this.firstName = firstName;
        }

        public string GetValue()
        {
            return firstName;
        }

        public static void  IsFirstNameVoid(string firstName)
        {
            if (firstName == null)
            {
                throw new ArgumentException("name cannot be null");
            }
        }

        public static void IsFirstNameValidLength(string firstName)
        {

            if (firstName.Length > 20 || firstName.Length < 3)
            {
                throw new ArgumentException("first name must be between 3 and 20 characters");
            }
        }
        public static void IsFirstNameValidRegex(string firstName)
        {
            string pattern = @"^[a-zA-Z]+$";
            Regex rg = new Regex(pattern);
            if (!rg.IsMatch(firstName))
            {
                throw new ArgumentException("first name cannot be special characters");
            }
        }

    }
}
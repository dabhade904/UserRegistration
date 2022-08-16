using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_L_Name_Pattern = "^[A-Z]{1}[a-z]{2,}$";
        public static string Email_ID_Pattern = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public static string Mobile_Pattern = "^[0-9]{2,2}[ ][7,8,9]{1,1}[0-9]{9}$";
        public static void getFullNamePattern(string pattern)
        {
            var match = Regex.IsMatch(pattern, F_L_Name_Pattern);
            if (match)
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Not Valid , Name Should start with Caps and has minimun 3 characters");
            }
        }

        public static void getEmailID(string email)
        {
            var match = Regex.IsMatch(email,Email_ID_Pattern);
            if (match)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email ID is not valid ");
            }
        }

        public static void getMobileNumber(string mobile)
        {
            var match = Regex.IsMatch(mobile, Mobile_Pattern);
            if (match)
            {
                Console.WriteLine("Mobile number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is not valid ");
            }
        }
    }
}
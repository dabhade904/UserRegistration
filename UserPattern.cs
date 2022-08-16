using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_Name_Pattern = "^[A-Z]{1}[a-z]{2,}$";

        public static void getFullNamePattern(string pattern)
        {
            var match = Regex.IsMatch(F_Name_Pattern, pattern);
            if (match)
            {
                Console.WriteLine("First name is valid");
            }
            else
            {
                Console.WriteLine("Not Valid ,First Name Should start with Caps and has minimun 3 characters");
            }
        }
    }
}
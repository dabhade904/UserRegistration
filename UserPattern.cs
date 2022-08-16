using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserPattern
    {
        public static string F_L_Name_Pattern = "^[A-Z]{1}[a-z]{2,}$";

        public static void getFullNamePattern(string pattern)
        {
            var match = Regex.IsMatch(F_L_Name_Pattern, pattern);
            if (match)
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Not Valid , Name Should start with Caps and has minimun 3 characters");
            }
        }
    }
}
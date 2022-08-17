namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: \n 1. Enter First Name \n 2. Enter Last Name \n 3. Email ID   \n 4. Mobile number \n 5. Enter Password \n 6. Enter Email ID to check \n 0. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter first name to check is valid or not");
                    string fName = Console.ReadLine();
                    UserPattern.getFullNamePattern(fName);
                    break;
                case 2:
                    Console.WriteLine("Enter last name to check is valid or not");
                    string lName = Console.ReadLine();
                    UserPattern.getFullNamePattern(lName);
                    break;
                case 3:
                    Console.WriteLine("Enter Email ID to check is valid or not");
                    string email = Console.ReadLine();
                    UserPattern.getEmailID(email);
                    break;
                case 4:
                    Console.WriteLine("Enter mobile number to check is valid or not");
                    string mobile = Console.ReadLine();
                    UserPattern.getMobileNumber(mobile);
                    break;
                case 5:
                    Console.WriteLine("Enter password to check is valid or not");
                    string password = Console.ReadLine();
                    UserPattern.getUserPassword(password);
                    break;
                case 6:
                    Console.WriteLine("Enter Email id to check is valid or not");
                    string clearAllEmails = Console.ReadLine();
                    UserPattern.getPassAllEmails(clearAllEmails);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
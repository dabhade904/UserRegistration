namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: \n 1. Enter First Name \n 2. Enter Last Name \n 3. Email ID   \n 4. Mobile number");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter first name");
                    string fName = Console.ReadLine();
                    UserPattern.getFullNamePattern(fName);
                    break;
                case 2:
                    Console.WriteLine("Enter last name");
                    string lName = Console.ReadLine();
                    UserPattern.getFullNamePattern(lName);
                    break ;
                case 3:
                    Console.WriteLine("Enter Email ID");
                    string email = Console.ReadLine();
                    UserPattern.getEmailID(email);
                    break ;
                case 4:
                    Console.WriteLine("Enter mobile number");
                    string mobile = Console.ReadLine();
                    UserPattern.getMobileNumber(mobile);
                    break;
            }
          

           

         
        }
    }
}
﻿namespace UserRegistrationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            UserPattern.getFullNamePattern(fName);       }
    }
}
using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "adming";
            string password = "pass1234";
            string userName, userpassword;
            
            Console.WriteLine("enter your username ");
         

            userName = Console.ReadLine();
            Console.WriteLine("enter your password ");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword);
                Console.WriteLine("welcome");
            else
                Console.WriteLine("oops. Something went wrong);
        }
    }
}

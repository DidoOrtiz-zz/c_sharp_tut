using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = "";

            while (pass != "secret")
            {
                Console.WriteLine("Enter your user");
                var user = Console.ReadLine();

                Console.WriteLine("Enter your password");
                pass = Console.ReadLine();

                if (pass != "secret")
                {

                    Console.WriteLine("Your User or Password are not correct.");
                }

            }

            Console.WriteLine("You are authenticated in the System.");

        }
    }
}

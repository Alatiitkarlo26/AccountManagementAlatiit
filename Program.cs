namespace AccountManagementAlatiit
  
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ACCOUNT MANAGEMENT SYSYEM");

            string username = "karlopogi";

            string password = "karlolangmalakas123!";

            Console.Write("Enter username: ");
            string inputUser = Console.ReadLine();

            Console.Write("Enter password: ");
            string inputPass = Console.ReadLine();


            if (inputUser == username && inputPass == password) {
                Console.WriteLine("Login successfull"); 
                }
            else { 
               Console.WriteLine("Incorrect credentials.");
        }
    }
}
}

   

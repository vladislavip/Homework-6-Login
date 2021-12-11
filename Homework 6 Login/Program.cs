using System;

namespace Homework_6_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();

            step1:
            Console.WriteLine("Type your new username");
            a.Username = Console.ReadLine();

            Console.WriteLine("Type your new password");
            a.Password = Console.ReadLine();

           

            bool b= a.CheckLoginAndPassword();

            if (b==false)

            { goto step1; }







        }




        
    }
}

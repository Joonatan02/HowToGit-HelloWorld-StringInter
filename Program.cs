using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What is your name");
            string FirstName;
            string LastName;
            Console.WriteLine("What is your first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            LastName = Console.ReadLine();
            
            //Console.WriteLine("Hello, " + FirstName + " " + LastName);
            //$ - alt + ctrl+4 { - alt gr + 7 } - alt gr + 0
            Console.WriteLine($"Hello, {FirstName} {LastName}");


        }
    }
}

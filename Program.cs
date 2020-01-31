using System;

namespace UserInputAngelicaNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Angelica Nguyen");
            Console.WriteLine("Say hi back and then hit enter!");
            string greeting;
            greeting = Console.ReadLine();
            Console.WriteLine("You typed:" + greeting);

        }
    }
}

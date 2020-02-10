using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
            Console.WriteLine(Math.Pow(3,2));
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name!);
        }
    }
}

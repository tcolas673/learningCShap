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
            sayHi(name);
            int[,] array = new int[2,3];
            array[0, 0] =1;
            Console.WriteLine(array[0,0]);
            Console.WriteLine(array[0,1]);
            Console.WriteLine(array[1,1]);
        }
        static void sayHi(string name) 
        {
            Console.WriteLine("Hello " + name!);
        }
    }
}

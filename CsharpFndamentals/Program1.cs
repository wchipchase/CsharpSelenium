using System;
using System.Diagnostics;

namespace CSharpfndamentals
{
    class Program1
    {
        public void getData()
        {
            Console.WriteLine("I'm inside the method");
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 4;
            Console.WriteLine("Number is " + a);

            String name = "Wayne";
            Console.WriteLine("Name is " + name);// concatenated string

            Console.WriteLine($"Name is {name}"); //evaluated string

            var age = 51;
            Console.WriteLine($"Age is {age}"); //var keyword.= don't have to specify data types Use sparingly

            dynamic height = 24.3; //Dynamic data types. Can change a double into a string
            Console.WriteLine($"Height is {height}");
            height = "hello";
            Console.WriteLine($"Height is {height}");

            Program1 p = new Program1();
            p.getData();
        }
    }
}

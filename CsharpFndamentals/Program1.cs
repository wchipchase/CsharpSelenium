using CsharpFndamentals;
using System;
using System.Diagnostics;

namespace CSharpfndamentals
{
    class Program1 : Program4  //inheritance
    {
        public void getData()
        {
            Console.WriteLine("I'm inside the method");
        }

        // Method defualt constructor used to initialize variable
        String name;
        String lastname;
        public Program1(String name)
        {
            this.name = name;
        }

        public Program1(String name, String lastname)
        {
            this.lastname = lastname;
        }

        public void getName()
        {
            Console.WriteLine("My name is " + this.name + " " +this.lastname);
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

            Program1 p = new Program1("Wayne");
            Program1 p1 = new Program1("Wayne", "Chipchase");
            p.getData();
            p.setData();
            p.getName();
            p1.getName();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        String[] a = { "hello", "bye", "Wayne", "Chipchase" };
        int[] b = { 1, 2, 3, 4, 5 };

        String[] a1 = new String[4];
        a1[1] = "hello";
        a1[2] = "Bye";
Console.WriteLine(a1[1]);

for(int i = 0; i < a.Length; i++)  //printing elements of an array with a for loop
{
    Console.WriteLine(a[i]);
    if (a[i] == "Wayne")   //using if condition to match an arra element
    {
        Console.WriteLine("Match found");
        break;
    }
}

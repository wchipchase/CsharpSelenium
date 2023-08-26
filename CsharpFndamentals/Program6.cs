using System;
using System.Collections;

ArrayList a = new ArrayList();               //If you don't know how many items in your collection
a.Add("Hello");
a.Add("Bye");
a.Add("Wayne");
a.Add("Chipchase");

Console.WriteLine(a[1]);


foreach (String item in a)
{
    Console.WriteLine(item);
}

a.Contains("Wayne");

Console.WriteLine(a.Contains("Wayne"));

Console.WriteLine("After Sorting");

a.Sort();
foreach (String item in a)
{
    Console.WriteLine($"{item}");
}
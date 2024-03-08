using System;

namespace Test13_Object_ReferenceEquals;
class Program
{
    static void Main(string[] args)
    {
        string str1, str2;
        str1 = "c# test";
        str2 = "c# test";

        Console.WriteLine(Object.ReferenceEquals(str1, str2)); //True

        int a, b;
        a = 2;
        b = 4;
        Console.WriteLine(Object.ReferenceEquals(a, b)); //False
    }
}

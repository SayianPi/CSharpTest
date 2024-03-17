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
        Console.WriteLine(Object.ReferenceEquals(str1, str1)); //True
        Console.WriteLine(Environment.NewLine);


        string a = null;
        string b = null;
        Console.WriteLine(Object.ReferenceEquals(a, b)); //True
        Console.WriteLine(Environment.NewLine);

        string a1 = "5";
        string b1 = "5";
        Console.WriteLine(Object.ReferenceEquals(a1, b1)); //True
        Console.WriteLine(Environment.NewLine);

        int a2 = 12;
        int b2 = 13;
        Console.WriteLine(Object.ReferenceEquals(a1, b1)); //True
        Console.WriteLine(Environment.NewLine);

        int a3 = 15;
        int b3 = 15;
        Console.WriteLine(Object.ReferenceEquals(a1, b1)); //True
        Console.WriteLine(Environment.NewLine);

        object x = null;
        object y = null;
        object z = new object();
        Console.WriteLine(Object.ReferenceEquals(x, y)); //True
        Console.WriteLine(Object.ReferenceEquals(x, z)); //False
        Console.WriteLine(Environment.NewLine);

        string s1 = "hello";
        string s2 = String.Copy(s1); //creates a new instance of string with the same value
        Console.WriteLine(Object.ReferenceEquals(s1, s2));//False


    }
}

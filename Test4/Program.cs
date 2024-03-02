using System;
namespace Test4
{
    class PrePostIncrement
    {
        static void Main(string[] args)
        {
            int a = 15, b;
            Console.WriteLine("output 1: " + a); //15
            b = ++a;
            Console.WriteLine("output 2: " + b); //16
            Console.WriteLine("output 3: " + a); //16

            int p = 12, q;
            Console.WriteLine($"output I: {p}"); //12
            q = p++;
            Console.WriteLine($"output II: {q}"); //12
            Console.WriteLine($"output III: {p}"); //13


            int x = 20, y = 15, v= 11, w = 10, z;
            z = ++x + v++; //21+11=32
            Console.WriteLine("outpput 4: " + z); //33

            z = ++y + w++; //16+10=26
            Console.WriteLine("output 5: " + z); //26

            z = v + w; //12+11=23
            Console.WriteLine($"output 6: {z}"); //23

        }
    }
}
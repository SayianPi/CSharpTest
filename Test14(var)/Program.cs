using System;

namespace Test14_var;
class Program
{
    static void Main(string[] args)
    {
        var greet = "namaste";
        var name = "bill";
        Console.WriteLine($"{greet} {name}");

        int i = 0;
        for(; ; )
        {
            if (i < 5)
            {
                Console.Write(i);
            }
            else
                break;
            i++;
        }
    }
}

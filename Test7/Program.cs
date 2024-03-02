using System;
namespace Test7
{
    class IncDec
    {
        static void Main(string[] args)
        {
            int a =11, b =12, c = 13, d = 14, e;
            Console.WriteLine(--a); //10
            Console.WriteLine(b--); //12
            Console.WriteLine(b); //11

            e = --c + ++d + b; //12+15+11=38
            Console.WriteLine(e); //38
            Console.WriteLine("Remember.. Now, you are a pro at pre/post incremennt/decrement");
        }
    }
}
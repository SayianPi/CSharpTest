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
            Console.WriteLine(a); //10

            e = --c + ++d + b; //12+15+11=38
            Console.WriteLine(e); //38
            Console.WriteLine("Remember.. Now, you are a pro at pre/post incremennt/decrement");


            int x = 10, y = 12, z;
            x += x; //10+10=20
            Console.WriteLine(x); //20

            z = ++y + y++; //13+13=26
            Console.WriteLine(z); //26

            int p = 11, q = 12, r;
            r = p++ + ++p; //11+13 = 24
            Console.WriteLine(r); //24

            r = q++ + ++q + ++q; //12+14+15 = 41
            Console.WriteLine(r); //41

            int s = 10, t = 11, u;
            u = s++ + ++t + s; //10+12+11=33
            Console.WriteLine(u); //33

        }
    }
}
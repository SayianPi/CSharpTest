using System;
using System.Text.RegularExpressions;
namespace Test9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4, c;
            /* c += a; */ //error: use of unassigned local variable c.
            /* c = a +; */ //error: use of unassigned local variable c.
            /* c *= b; */ //error: use of unassigned local variable c.

            c = +a; //5
            Console.WriteLine($"+a = {c}"); //5
            double d = Math.Pow(b, 3); //4 to the power 3 = 64
            Console.WriteLine(d); //64


            Console.WriteLine("--------------------------------------------------");

            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int year = DateTime.Now.Year;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(year);
            Console.WriteLine($"{hour}:{minute}:{sec}");

            Console.WriteLine("------------ OR -------------");

            DateTime time = DateTime.Now;
            Console.WriteLine(time); //3/3/2024 12:28:26 PM
            Console.WriteLine(time.Day); //current day
            Console.WriteLine(time.Month); //current month
            Console.WriteLine(time.Year); //2024
            Console.WriteLine(time.ToString("MMMM")); //March
           
            string now = DateTime.Now.ToString("dddd, dd MMMM yyyy, hh:mm tt"); 
            Console.WriteLine(now); //Sunday, 03 March 2024, 12:28 PM

            int x = 12, y = 11, z;
            x *= x; //x square or, x*x
            Console.WriteLine($"x *= x => {x}"); //144

            y += 1; //y+1 = 11+1 = 12
            y += 2; //y+2 = 12+2 = 14
            y += 3; //y+3 = 14+3 = 17
            Console.WriteLine(y); //17

        }
    }
}
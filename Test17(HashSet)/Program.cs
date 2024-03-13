﻿using System;

namespace Test17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var y; */ //ERROR: IMPLICITLY TYPES VARIABLE MUST BE INITIALIZED
            var x = 100;
            Console.WriteLine(x);

            x += x; //100+100
            Console.WriteLine(x); //200

            float f = 20.25f;
            long l = 100L;
            Console.WriteLine(f + l); //120.25
            Console.WriteLine(Environment.NewLine);


            for (double d = 1.01D; d < 1.05; d += 0.01D)
            {
                Console.Write("{0},", d); //1.01,1.01,1.02,1.03,1.04,
            }
            Console.WriteLine(Environment.NewLine);






            //HashSet
            HashSet<int> hs = new HashSet<int> {
                4, 1, 1, 2, 3, 3
            };
            foreach (var val in hs)
                Console.WriteLine(val);
            Console.WriteLine(Environment.NewLine);


            //UnionWith method
            HashSet<string> names1 = new HashSet<string>
            {
                "Ram",
                "Hanuman"
            };
            HashSet<string> names2 = new HashSet<string>
            {
                "shiva",
                "Ram",
                "Hanuman",
                "Ganesh"
            };
            names1.UnionWith(names2);
            foreach (var god in names1)
                Console.Write("{0},", god); //Ram, Hanuman, Shiva, Ganesh,
            Console.WriteLine(Environment.NewLine);

            names2.UnionWith(names1);
            foreach (var god in names2) 
                Console.Write("{0},", god); //Shiva, Ram, Hanuman, Ganesh, 
            Console.WriteLine(Environment.NewLine);


            //IntersectWith method
            HashSet<int> id1 = new HashSet<int>
            {
                1, 1, 2, 4
            };
            HashSet<int> id2 = new HashSet<int>
            {
                3, 6, 5, 6, 2, 1
            };
            id1.IntersectWith(id2);
            foreach (var id in id1)
                Console.Write("{0},", id); //1,2,
            Console.WriteLine(Environment.NewLine);

            id2.IntersectWith(id1);
            foreach (var id in id2)
                Console.Write("{0},", id); //2,1,
            Console.WriteLine(Environment.NewLine);

            //ExceptWith method
            HashSet<string> naam1 = new HashSet<string>
            {
                "roshan", "rohan", "rohit"
            };
            HashSet<string> naam2 = new HashSet<string>
            {
                "roshan", "rajan", "ramesh", "rohan"
            };         
            naam2.ExceptWith(naam1);
            foreach (var name in naam2)
                Console.WriteLine(name); //rajan
                                         //ramesh
          
        }
    }
}

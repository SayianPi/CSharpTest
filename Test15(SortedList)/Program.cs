using System;
using System.Collections;

namespace Test15_SortedList;
class Program
{
    static void Main(string[] args)
    {
        SortedList sortedList = new SortedList() { { 2, true }, { 1, "one" }, };
        foreach(DictionaryEntry kvp in sortedList)
        {
            Console.Write(kvp.Value); //oneTrue
        }
    }
}
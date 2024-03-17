using System;

namespace Test19
{
    // for 2.
    class Person
    {
        public int id;
        public override string ToString() => this.id.ToString();
       
    }
    class Program
    {
        // for 3.
        static bool DoSomething()
        {
            Console.WriteLine("reading");
            return false;
        }
      
        static void Main(string[] args)
        {
         
            // 1.
            int?[] arr = new int?[5];
            Console.WriteLine(arr[0]);

          
            // 2.
            Person p = new Person() { id = 1 };
            Console.WriteLine(p.ToString()); //1

            // 3.
            while(DoSomething()); //reading

            // 4.
            int i = 3;
            const int j = 3;
            int[] array = new int[j] {10, 20, 30}; //when use 'i' error: cannot use 'i', a constant value is expected.
            Console.WriteLine(array[0]);

           
        }
    }
   
}

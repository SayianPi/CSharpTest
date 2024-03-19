using System;

namespace DelegateExercise
{
    public delegate void MyDelegate(int num1, int num2);
    class Math
    {
        static int result;
        public static void Addition(int n1, int n2)
        {
            result = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}", n1, n2, result);
        }
        public static void Multiplication(int n1, int n2)
        {
            result = n1 * n2;
            Console.WriteLine("{0} * {1} = {2}", n1, n2, result);
        }
        public static void Division(int n1, int n2)
        {
            result = n1 / n2;
            Console.WriteLine("{0} / {1} = {2}", n1, n2, result);
        }
    }
    class Program
    {
        static void InvokeDelegate(MyDelegate myd) //delegate as a parameter
        {
            myd(20, 10);
        }

        static void Main(string[] args)
        {
            MyDelegate mdadd = new MyDelegate(Math.Addition); //delegate object created
            InvokeDelegate(mdadd); //invoking using method that has a parameter delegate
            MyDelegate mdmul = new MyDelegate(Math.Multiplication);
            InvokeDelegate(mdmul);
            MyDelegate mddiv = new MyDelegate(Math.Division);
            InvokeDelegate(mddiv);
            Console.WriteLine(Environment.NewLine);

            
            //instead of creating different delegate for different method targets,
            //we can target the methods with single existing delegate object
            mdadd = Math.Multiplication;
            mdadd(6, 6); // 6*6=36 //invoking without using method
            mdadd = Math.Division;
            mdadd(10, 5); // 10/5=2
        }
    }
}

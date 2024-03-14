using System;
namespace TryCatchFinally
{
    class Division
    {
        int result; 
        Division() //CONSTRUCTOR
        {
            result = 0;
        }
        public void division(int x, int y) //METHOD
        {
            try
            {
                result = x / y; //10/0 (DIVIDED BY ZERO)
            }         
            catch(DivideByZeroException ex) //THIS GETS EXECUTED
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
            finally //THIS ALWAYS GETS EXECUTED REGARDLESS
            {
                Console.WriteLine("result: {0}", result);
            }
        }
    
    
        static void Main(string[] args)
        {
            Division d = new Division();
            d.division(10, 0);
            int[] array = { 1, 2, 3, 4, 5 };
            try
            {

                Console.WriteLine(array[10]); //INDEX OUT OF RANGE
            }
            /*
            catch (Exception ex) //THIS CATCH CLAUSE ALREADY CATCHES ALL EXCEPTIONS OR OF A SUPER TYPE
            {
                Console.WriteLine("error occured!");
            }
            */           
            catch (IndexOutOfRangeException ex) //THIS GETS EXECUTED
            {
                Console.WriteLine("index error occured!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("null error occured!");
            }
            finally //THIS ALWAYS GETS EXECUTED REGARDLESS
            {
                Console.WriteLine("this always gets executed regardless of the result.");
            }

        }
    }
}

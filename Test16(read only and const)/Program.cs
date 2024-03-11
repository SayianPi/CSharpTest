using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
namespace Test16_ReadOnly_Const;
public class One
{
    public readonly string country = "nepal"; //read only fields initialized at the declaration
    public readonly string city; //read only field declared

    readonly static int b = 12; //read only fields ca be used with the static modifier
    const static int a = 13; //const field cannot be used with the static modifier


    public One() //constructor
    {
        country = "china";
        city = "kathmandu"; //readonly fields can be initialized in the constructor
        /* public readonly String street; */ //read only field cannot be declared in constructor.
        const float tau = 6.2831f; //const field can be declared in constructor
        const int pi; //const field need to be initialized with declaration only.

    }


    static One() //static constructor
    {

    }


    public void OneMethod() //method
    {
        city = "kathmandu"; //read only fields cannot be initialized in the method
        readonly string street; //read only field cannot be declared in methods

        const float tau = 6.2831f; //const field can be declared in methods
        const int pi; //const field need to be initialized with declaration only.
       
    }


    public static void OneStaticMethod() //static method
    {
       

    }
    
}
class Program
{
    static void Main(string[] args)
    {
        
    }
}

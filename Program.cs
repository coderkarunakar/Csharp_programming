//here we are just importing the System
using System;

//working with name space
namespace consoleApp2
{
    //defining a class
    //this class allows us to model import object etc
    public class Program
    {
       
        static void Main(string[] args)
        {
            //Type casting :converting data types using Parse(we can convert)
            //converting string to bool
            bool boolFromStr = bool.Parse("true");

            //string to int
            int intFromStr = int.Parse("100");
            //string to double
            double dblFromStr = double.Parse("1.234"); 

            //double into a  string (here ToString is used to convert any datatype to string
            string strVal =dblFromStr.ToString();


            //here {} is used to get the data fetch from the defined
            Console.WriteLine($"Data type:{strVal.GetType()}");


            //Explicity convertion (loosing some data)

            //convert double into integer(here we loose all of the decimal value )
            double dblNum = 12.345;

            Console.WriteLine($"Integer:{(int)dblNum}");

            //implicit conversion  :here we convert all the data types into the larger data type
            int intNum = 10;
            long longNum = intNum;
            Console.WriteLine(longNum);


            //output for the above code:
                /*Data type:System.String
                Integer:12(here we loose the data)
                10*/






        }
    }
}
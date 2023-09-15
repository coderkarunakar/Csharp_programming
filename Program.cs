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
            //Formating output
            Console.WriteLine("Currency:{0:c}",23.455666);

            //here d4 means it will make it as 4 numbers by adding zeroes at the front   
            Console.WriteLine("Pad with 0s:{0:d4}", 23);
            //3decimals(it is going to  give u the 3 decimals)
            Console.WriteLine("3 decimals:{0:f3}", 23.45555);
            //it is goint to give  you 4 zeroes after this number decimal...
            Console.WriteLine("Commas:{0:n4}", 2300);


            //output for the above code

       /* Currency:? 23.45
            Pad with 0s: 0023
            3 decimals: 23.456
            Commas: 2,300.0000*/

        }
    }
}
//here we are just importing the System
using System;
using System.Collections.Generic;

//working with name space
namespace consoleApp2
{
    //defining a class
    //this class allows us to model import object etc
    public class Program
    {
        
        static void Main(string[] args)
        {
            //if else and else if
            //in conditional opertors we have 2 operators i.e realational operator:> < >= <= ==  != and in the logical operators:&& || !

            int age = 17;
            if((age>=5) &&(age<=7))
            {
                Console.WriteLine("Go to elementary School");
            }
            else if ((age >7) && (age <13))
            {
                Console.WriteLine("Go to Middle School");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to High School");
            }
            else {
                Console.WriteLine("Go to College");
            }
            if ((age <14) && (age < 67))
            {
                Console.WriteLine("To should not work");
            }
            Console.WriteLine("! true =" +(!true));


            //here we can use if statement else statement and instead of using if statement 2nd time we can use else if it is similar to elif which is in python










        }
    }
}
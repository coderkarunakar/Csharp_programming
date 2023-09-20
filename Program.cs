//here we are just importing the System
using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Dynamic;

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

            int age = 1;
           

            //Terinay operator:it is going to check the given condition is true or false ,by checking with the question mark and gives true or false since we have used bool
            bool canDrive = age >= 16 ? true : false;
            Console.WriteLine(canDrive);



            //Note:default get executed only when all the cases are not matching only ,and if once break is kept and case is matching only that case  will get executed and no default get executes vv.imp

            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day care");
                    //Note:this break brings out of the switch statement and wont check other statements
                    break;

                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                  
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;

                default:
                    Console.WriteLine("Go to another School");
                    //we can jump from switch statement by using go to,Even though default get executed or case statement get executed the goto will definetely work in all the cases 
                    goto OtherSchool;



            }
        OtherSchool:
            Console.WriteLine("Elementary,Middle,High School");




            string name2 = "Derek";
            string name3 = "Derek"; 
            if(name2.Equals(name3,StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            /*StringComparison.Ordinal:
             * lets you test for equality by calling either the static or instance Equals method overloads, or by using the static equality operator
             
            .Equals:used to determine whether two String objects have the same value or not. */



        }
    }
}
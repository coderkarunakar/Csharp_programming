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
            //While loop:we use while loop to execute the code as long as the condition is true
            int i = 1;
            while(i  <= 10)
            {

                //Note:continue means Skip it....
                //if the given no is even simply increment and continue(i.e Skip it) if it is odd print it and if it is 9 break and dont print 9
                if(i%2==0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }
                



        }
    }
}
//here we are just importing the System
using System;

//working with name space
namespace consoleApp2
{
    //defining a class
    //this class allows us to model import object etc
    public class Program
    {
        //all our code is start executing in our main code
        // static means it allows us to run with out creating an objects and void means this our function called main is not going to return any values
        //string array which contains bunch of data inside it 
        //any data i.e passed to args executes in a terminal window 

        static void Main(string[] args)
        {
           
            

            //there are a diffrent methods of console methods
            //if we want to change text color inside of our console

            Console.ForegroundColor = ConsoleColor.Red;
            //changing the color of window
            Console.BackgroundColor = ConsoleColor.White;
            //applying background color to entire window
            Console.Clear();
            //if u want to print to the screen use console
            Console.WriteLine("Hello World");
        }
    }
}
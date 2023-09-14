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
            //Receive User input
            //Write  inserts line after a new text 
            Console.Write("What is your name?");
            //storing names letters and text
            //for reading information from the user use ReadLine
            string name=Console.ReadLine();
            //user input on the console 
            //printing a message
            Console.WriteLine($"Hello {name}");

            

           
        }
    }
}
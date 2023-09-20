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
//in this program if  you enter some random values ,in that i will guess some random value and show on the screen


            //Do while: you must execute the code atleast one time

            
            //generating a new random value
                Random rnd = new Random();
            //here 1,11 are the min value and max value in between this only it will get executed

            //From here only a no is  generated in between 1,11 i.e till 10
            int secretNumber=rnd.Next(1,11);
            //number guessed by the user
            int numberGuessed = 0;
            Console.WriteLine("Random Num:", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 & 10:");
                //converting the entered number into an integer and Read.Line takes the input from the user untill the enter key is pressed,it reads each line of string or values from input
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while(secretNumber != numberGuessed);
            Console.WriteLine("You guessed it was {0}",secretNumber);




        }
    }
}
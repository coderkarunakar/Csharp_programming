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
            //Topic :Arrays and For loops


            //Arrays:
            //ex:a box is inside a bigger box and then they contains lot of multiple values all of the same data type and each item is acessed using an index,or a key and first index is zero

            //integer array
            //creating an array with 3 spaces inside in it
            int[] favNumbs = new int[3];
            //adding a number to it
            favNumbs[0] = 23;
            Console.WriteLine("favNum 0:{0}", favNumbs[0]);

            //create another array which contains custumer names
            string[] customers = { "Bob", "Salley", "Sue" };

            //creating array using Var key but it must be of same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            //creating array using objects
            object[] randomArray = { "Paul", 45, 1.234,"karunakar" };
            Console.WriteLine("randomArray 0:{0}",
                randomArray[0].GetType());
            Console.WriteLine("Array Size:{0}", randomArray.Length);

            //using a for loop for generating a index value
            for(int j=0;j<randomArray.Length;j++)
            {
                //for generating index value i have used j
                //here Array {0} is fetching its index and value is fetching value which starts with 1 and that goes on...
                Console.WriteLine("array:{0}:value:{1}",j, randomArray[j]);
            }
            Console.WriteLine("---------");


            //Creating a multidimensional array(2rows by 2columns

            string[,] custNames = new string[2, 2]
            {          
                
                        /*column0*/ /*column1*/
              /*row0*/  {"Bob","Smaith"},
               /*row1*/ {"Sally","Smith" }
                
            };
            //get a value inside the multidimensional array using indexes
            Console.WriteLine("MD Value:{0}", 
                //here the value is about row(first) and column(second) 
                //GetValue is used to get the value of specified element in the current Array
            custNames.GetValue(1,1));
                
            for(int j = 0; j < custNames.GetLength(0); j++)
            {
                for(int k = 0; k < custNames.GetLength(0); k++)
                {
                    Console.WriteLine("{0}", custNames[j,k]);

                }
                //for empty space
                Console.WriteLine();
            }

           










        }
    }
}
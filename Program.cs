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
        //---Functions
        //

        //static means we do not need to create a new object
        //here name of the function is PrintArray
        static void PrintArray(int[] intArray,string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0}:{1}",mess,k);
            }
        }



        //---------End of Functions--
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
            object[] randomArray = { "Paul", 45, 1.234, "karunakar" };
            Console.WriteLine("randomArray 0:{0}",
                randomArray[0].GetType());
            Console.WriteLine("Array Size:{0}", randomArray.Length);

            //using a for loop for generating a index value
            for (int j = 0; j < randomArray.Length; j++)
            {
                //for generating index value i have used j
                //here Array {0} is fetching its index and value is fetching value which starts with 1 and that goes on...
                Console.WriteLine("array:{0}:value:{1}", j, randomArray[j]);
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
            custNames.GetValue(1, 1));

            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                for (int k = 0; k < custNames.GetLength(0); k++)
                {
                    Console.WriteLine("{0}", custNames[j, k]);

                }
                //for empty space
                Console.WriteLine();
            }
            int[] randNums = { 1, 4, 9, 2,8,100 };

            //function name and passing an array and the message is ForEach and the iteration is taking from the above randNums
            PrintArray(randNums, "ForEach");
            Console.WriteLine("------------");

            //Sorting an  array
            Array.Sort(randNums);

            //Reverse an array
            Array.Reverse(randNums);

            //getting an specified index value of an array
            //here actually that {0} is fetching to 1 which is in randNums
            Console.WriteLine("1 at index:{0}",
                Array.IndexOf(randNums, 1));


            //Change the value at an index
            randNums.SetValue(0, 1);


            //copy an array to an another part of an array

            //source array
            int[] srcArray = { 1, 2, 3 };
            //destination array
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            //with this i can copy elements from 0 to till upto lenght 2
            Array.Copy(srcArray,startInd, destArray,0,length);
            PrintArray(destArray, "Copy");

            //here 10 is length
            Array anotherArray=Array.CreateInstance(typeof(int), 10);

            //here startInd is 5
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo:{0}", m);

            }

            /*favNum 0:23
            randomArray 0:System.String
            Array Size:4
            array:0:value:Paul
            array:1:value:45
            array:2:value:1.234
            array:3:value:karunakar
            ---------
            MD Value:Smith
            Bob
            Smaith

            Sally
            Smith

            ForEach:1
            ForEach:4
            ForEach:9
            ForEach:2
            ForEach:8
            ForEach:100
            ------------
            1 at index:5
            Copy:1
            Copy:2
            CopyTo:0
            CopyTo:0
            CopyTo:0
            CopyTo:0
            CopyTo:0
            CopyTo:1
            CopyTo:2
            CopyTo:3
            CopyTo:0
            CopyTo:0
            */


            //Difference between For loop and For Each loop
            
            /*For loop executes the code until the given condition is False
             where as the ForEach loop executes the code
            untill all the elements get completed in the code
            */














        }
    }
}
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

            //String
            //Note:this whole string which is in double quote is reffered as index 0 i.e {0}

            string randString = "This is a String";

            //get no of character in the string
            Console.WriteLine("String length:{0}", randString.Length);

            //it is going to return true or false
            Console.WriteLine("String contains is :{0}", randString.Contains("is"));


            //get the idex of a specif character in the given string 
            Console.WriteLine("Index of is:{0}", randString.IndexOf("is"));

            //remove the no of character from starting and a specif index
            Console.WriteLine("String length:{0}", randString.Length);

            //remove string
            Console.WriteLine("Remove String :{0}", randString.Remove(10,6));

            //insert string
            Console.WriteLine("Insert String :{0}", randString.Insert(10,"short"));

            //replace a string
            Console.WriteLine("Replace String:{0}", randString.Replace("string","sentence"));

            //Compare a string
            Console.WriteLine("Compare A to B:{0}", String.Compare("A","B",
                StringComparison.OrdinalIgnoreCase));


            //bit confusion here
            //compare strings and ignore case
            //<0:str1 preceeds str2(above is this case)
            //=:Zero
            //>0:str2 preceeds str1

            Console.WriteLine("----------");  
            
            //comparing uppercase A and lower case a
           Console.WriteLine("A=a:{0}",String.Equals("A","a",
               StringComparison.OrdinalIgnoreCase));

            //Add padding to a string
            //this will add a padding with dots at the left side
            Console.WriteLine("Pad Left:{0}",
                randString.PadLeft(20,'.'));

            //Adding padding to the right
            //this will add a padding to the right side with dots
            Console.WriteLine("Pad Right:{0}",
                randString.PadRight(20, '.'));

            //Trim (i.e white space
            //it removes all the leading and trailing white spaces
            Console.WriteLine("Trim:{0}",
                randString.Trim());


            Console.WriteLine("UpperCase:{0}",
                randString.ToUpper());

            Console.WriteLine("LowerCase:{0}",
                randString.ToLower());

            //Formating the string
            //Note:{0} means whole string which is in double quotes
            string newstring = string.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");


            //adding the new line to the string
            Console.Write(newstring + "\n");

            //to use a double quote inside the string
            //  \'\"\\ \t \a
            Console.WriteLine(@"Exactly what I typed\n");








        }
    }
}
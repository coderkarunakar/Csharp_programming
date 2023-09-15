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
            //variables:stores some specif type of data
            //bool can have a true or a false
            bool canIVote = true;

            //integers it can have 32 bit or 64 bit,here we can use $ or {} as well,and MaxValue gives you the biggest integer in integers 
            Console.WriteLine("Biggest Integer:{0}", int.MaxValue);

            //smallest integer
            Console.WriteLine("Smallest Integer:{0}", int.MinValue);

            //it is going to store 64 bit
            Console.WriteLine("Biggest Long:{0}", long.MaxValue);

            Console.WriteLine("Smallest Long:{0}", long.MinValue);

            decimal decPiVal = 3.1415M;

            //bignum is going to store 128 bit
            decimal decBigNum = 3.000M;
            Console.WriteLine("DEC:PI+bigNum={0}",decPiVal+decBigNum);



            Console.WriteLine("Biggest Decimal:{0}", Decimal.MaxValue);

            Console.WriteLine("Bigggest Double:{0}", Double.MaxValue);

            double dblPiVal = 3.1415;
            double dblBigNum = 3.1415;
            Console.WriteLine("DBL:PI+bigNum={0}", dblPiVal+dblBigNum);


            Console.WriteLine("Bigggest Float:{0}", float.MaxValue);

            double fltPiVal = 3.1415F;
            double fltBigNum = 3.0002F;
            Console.WriteLine("FLT:PI+bigNum={0}", fltPiVal + fltBigNum);



            //output for the above code is 
            //Biggest Integer:2147483647
//Smallest Integer:-2147483648
//Biggest Long:9223372036854775807
//Smallest Long:-9223372036854775808
//DEC: PI + bigNum = 6.1415
//Biggest Decimal:79228162514264337593543950335
//Bigggest Double:1.7976931348623157E+308
//DBL: PI + bigNum = 6.283
//Bigggest Float:3.4028235E+38
//FLT: PI + bigNum = 6.141700029373169





            /*other different data types are as follows
            *byte:8-bit unsigned int 0 to 255
            *char:16-bit unicode character 
            *sbyte:8-bit signed int 128 to 127
            *short:16-bit signed int-32,768 to 32,767
            *uint:32-bit unsigned int 0 to 4,294,967,295
            *ulong:64bit unsigned int 0 to  *18,446,744,073,709,551,615
            *ushort:16-bit unsigned int 0 to 65,535*/


            //NOTE:
            //difference between console.write(prints without new line) and console.writeline(prints with new line) 





        }
    }
}
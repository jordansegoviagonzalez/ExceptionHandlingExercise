using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr
            //Below this array contains 6 number and 3 letters as required. 
            var arr = new Char[] {'1','2','3','4','5','6','a','b','c'};
            //'var' tells the compiler to infer the type, which becomes 'char []' here.
            //'arr' is the name of the character array.
            //'new Char[]' creates a new array to hold characters.
            //The array includes 6 numeric characters ('1' to '6') and 3 alphabetic characters ('a','b','c').
            
            // 2) Create a list called numbers that will hold integers
            //Below I am creating a new empty list to store ints.
            
            var numbers = new List<int>();
            //'var' tells the compiler to infer the type, which becomes 'List<int>' here.
            //'numbers' is the name oif the list
            //'new List<int>()' creates a new empty list that will store ints values.
        
            // 3) Create an string variable with an empty string initializer - name it str
            //Below I created a string variable initialized as an empty string 
            var str = "";
            //'var' lets the compiler infer the type, which becomes 'string' here.
            //'str' is the name of the string variable.
            //'""' initializes the string as empty.

            // 4) Make a foreach loop to iterate through your character array            
            // 5) Create a try-catch inide of your foreach loop
            // 6) Inside the try block: 
            // 7) Set your string variable to each array element in your char[] to .ToString()
            // 8) Now, using int.Parse, parse your string variable and store in an int variable
            // 9) Then add each int to your list

            // 10) Inside the catch block:
            // 11) In the scope of your catch you can use the following code:                  
            // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
            
            //Below we have a that will loop thought each character in the 'arr' array.
            foreach (var character in arr)
                //'foreach' is a loop that goes through each element in the 'arr' array one by one.
            //'var character' declares the loop variable that represents each individual element in the array.
            //During each interaction, 'character' holds the current value from the array
            {
                try
                    // 'try' is used to run code that might throw an exeption (an error).
                    //if an exeption occurs, control jumps to the 'catch' block.
                {
                    str = character.ToString();
                    //'character.ToString()' converts the current character to a string.
                    //The result is stored in the 'str' variable
                    numbers.Add(int.Parse(str));
                    //'int.Parse(srt)' tries to convert to string value of 'str' into an int.
                    //if successful, the int is added to the 'number' list using the 'Add' method.
                }
                catch (FormatException e)
                    //'catch' is used to handle exception throw in the 'try' block.
                    //'FormatException' is a specific error type that occurs when parsing a string fails.
                    //'e' is a variable that holds the details of the exception.
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                    //'Console.WriteLine' prints a message to the output console.
                    //The message uses string interpolation ("$...") to include the actual character that failed to parse.
                }
                //This catch block is a general exception handler that catches any exception type.
                catch (Exception e)
                {
                    //'Exception' is the base class for all exception in C#
                    //'e' is the variable that holds the exception objects thrown during program execution.
                    
                    Console.WriteLine(e.Message);
                    //'Console.WriteLine(e.Message)' prints the message associated with the exception to the console.
                    //'e.Message' provides a short description of what went wrong.
                    
                }
            }


            // Uncomment the code below to see the numbers you successfully added to the numbers list: 
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

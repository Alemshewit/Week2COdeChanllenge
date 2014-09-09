using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //run a for loop from 0 to 20 and call the function FizzBuzz and test the function between 0 and 20
            for (int i= 0; i <= 20; i++)
            {
                //call the function fizzbuzz
                FizzBuzz(i);   
            }

            //print to console an empty line
            Console.WriteLine();
            //call the function LetterCounter with the following parameters
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            //print to console an empty line
            Console.WriteLine();
            //call the function LetterCounter with the following parameters
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            //print to console an empty line
            Console.WriteLine();
            //call the function LetterCounter with the following parameters
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            //keep console open
            Console.ReadKey();

        }
        //create a function FizzBuzz that checks to see if a number is divisible by 5 and 3, 5, or 3 and 
        //prints FozzBizz, fizz, or buzz
        static void FizzBuzz(int number)
        {
            //test a condition with an if/else if statement to see if the number being tested is
            //divisible both by 5 and 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                //if condition above is true, print to the console FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
            //check if the number is divisible by 5
            else if (number % 5 == 0)
            {
                //if the condition above is true print Fizz to console
                Console.WriteLine("Fizz");
            }
            //check to see if number is divisible by 3
            else if (number % 3 == 0)
            {
                //if the condition above is true print Buzz to console
                Console.WriteLine("Buzz");
            }
            //if any of the above conditions fail, execute
            else
            {
                //print to console the number if it isn't divisible by either of those numbers
                Console.WriteLine(number);
            }
        }

        //create a function Letter Counter that takes two parameters, one char and one string
        static void LetterCounter(char letter, string inString)
        {
            //declare integer variables to store the number of lowercase, uppercase, and total letters
            int lowerCase = 0;
            int upperCase = 0;
            int numLetters = 0;
            //fun a for loop from 0 to total length of the given string
            for (int i = 0; i < inString.Length; i++)
            {
                //test a condition to see if a lowercase char in the argument is contained within the string in the argumet
                if (inString[i].ToString().Contains(letter.ToString().ToLower()))
                {
                    //Every time there is a match increment the lowerCase total by 1
                    lowerCase += 1;
                    //increment the total number of letters by 1 
                    numLetters += 1;
                }
                //test to see if the same letter in uppercase is contained with in the string 
                else if (inString[i].ToString().Contains(letter.ToString().ToUpper()))
                {
                    //if the above condition is true increment the upperCase total by 1
                    upperCase += 1;
                    //increment total number of letters found by 1
                    numLetters += 1;
                }
            }
            //print result to console in the following order
            Console.WriteLine(inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + lowerCase);
            Console.WriteLine("Number of UPPECASE " + letter + "'s found: " + upperCase);
            Console.WriteLine("Total Number of " + letter + "'s found: " + numLetters); 
        }
    }
}

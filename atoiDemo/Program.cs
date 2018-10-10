using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//console application demo.  attemp
namespace atoiDemo
{
    class Program
    {
        //method to mimic atoi functionality
        static int atoiTest(string s)
        {
            //initialize variables
            int result = 0;
            int posNeg = 1;
            int i = 0;

            //check for null or empty string
            if (s == null || s.Trim().Length == 0)
            {
                return result;
            }
            //check if the first char is a - sign.  increment i
            if (s[i] == '-')
            {
                posNeg = -1;
                i++;
            }
            //check if the first char is a + sign.  increment i
            if (s[i] == '+')
            {
                posNeg = 1;
                i++;
            }

            //loop through remaining string
            for (; i < s.Length; ++i) 
                {
                    //if char is not numeric break out
                    if (isNumeric(s[i]) == false)
                    {
                    //display error message
                    Console.WriteLine(s[i] + " was not a numeric character!");
                        break;
                    }

                //if numeric, apend to result
                result = result * 10 + s[i] - '0';
            }
             
            //return result
            return posNeg * result;
        }

        //static method to check if a value is numeric
        //requirement was that if i call a method, i have to 
        //implement it.  cant use tryparse
        static bool isNumeric(char x)
        {
            return  (x >= '0' && x <= '9')? true : false;
        }



        static void Main(string[] args)
        {
            //start at true and provide instructions
            bool inputString = true;
            Console.WriteLine("Please input a string to calculate the atoi value.  Enter q to quit.");
            while (inputString)
            {
                string input = Console.ReadLine();
                //quit if input is q
                if (input.ToLower() == "q")
                {
                    inputString = false;
                }
                else
                {
                    //calculate atoi value for input string
                    int val = atoiTest(input);
                    Console.WriteLine("Atoi value is: " + val);
                }
            }
        }
    }
}

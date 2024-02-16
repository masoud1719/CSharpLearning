using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    internal class Program
    {
        /// <summary>
        /// Document comment
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comment
            // single line comment


            /*
             * multiline
             * comment
             */

            #endregion

            #region C# Output
            // To output values or print text in C#, you can use the WriteLine() method:

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("I am Learning C#");
            //Console.WriteLine("It is awesome!");

            // You can also output numbers, and perform mathematical calculations:
            //Console.WriteLine(3 + 3);

            #endregion

            #region  C# Variables
            /*  Variables are containers for storing data values.
             *  In C#, there are different types of variables (defined with different keywords), for example:
             *  int - stores integers (whole numbers), without decimals, such as 123 or -123
             *  double - stores floating point numbers, with decimals, such as 19.99 or -19.99
             *  char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
             *  string - stores text, such as "Hello World". String values are surrounded by double quotes
             *   bool - stores values with two states: true or false
            */

            //// Declaring(Creating) Variables
            //// type variableName = value;
            //string name = "John";
            //Console.WriteLine(name);

            //int myNum = 15;
            //Console.WriteLine(myNum);

            //// You can also declare a variable without assigning the value, and assign the value later:
            //int myNum;
            //myNum = 15;
            //Console.WriteLine(myNum);

            //// Examples
            //int myNum = 5;
            //double myDoubleNum = 5.99D;
            //char myLetter = 'D';
            //bool myBool = true;
            //string myText = "Hello";
            #region Constant Variables
            /*
             * If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
             * An example that is often referred to as a constant, is PI (3.14159...).
             */
            //const int myNum = 15;
            //myNum = 20; // error (visual studio will show the error before run the program as well.)

            #endregion
            #region Identifier
            /*
                *All C# variables must be identified with unique names.
                *These unique names are called identifiers.
                *Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
                *Note: It is recommended to use descriptive names in order to create understandable and maintainable code:
            */
            //// Good
            //int minutesPerHour = 60;

            //// OK, but not so easy to understand what m actually is
            //int m = 60;

            /*
                *The general rules for naming variables are:
                *Names can contain letters, digits and the underscore character (_)
                *Names must begin with a letter or underscore
                *Names should start with a lowercase letter, and cannot contain whitespace
                *Names are case-sensitive ("myVar" and "myvar" are different variables)
                *Reserved words (like C# keywords, such as int or double) cannot be used as names
            */

            #endregion
            #endregion


            Console.ReadKey();
        }
    }
}

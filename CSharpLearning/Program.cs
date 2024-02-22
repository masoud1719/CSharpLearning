using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
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

            #region C# Data Types

            ////  Data Type   Size    Description
            ////  int         4       bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
            ////  long        8       bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ////  float       4       bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            ////  double      8       bytes Stores fractional numbers.Sufficient for storing 15 decimal digits
            ////  bool        1       bit   Stores true or false values
            ////  char        2       bytes Stores a single character / letter, surrounded by single quotes
            ////  string      2       bytes per character   Stores a sequence of characters, surrounded by double quotes

            //int myNum = 5;               // Integer (whole number)
            //double myDoubleNum = 5.99D;  // Floating point number
            //char myLetter = 'D';         // Character
            //bool myBool = true;          // Boolean
            //string myText = "Hello";     // String
            //float f1 = 35e3F;
            //double d1 = 12E4D;
            //Console.WriteLine(f1);
            //Console.WriteLine(d1);

            ////Use float or double?
            ////The precision of a floating point value indicates how many digits the value can have after the decimal point.
            ////The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            ////Therefore it is safer to use double for most calculations.
            #endregion

            #region C# Type Casting
            /*
            *Type casting is when you assign a value of one data type to another type.
            *In C#, there are two types of casting:
            *Implicit Casting (automatically) - converting a smaller type to a larger type size
                *char -> int -> long -> float -> double
            *Explicit Casting (manually) - converting a larger type to a smaller size type
                *double -> float -> long -> int -> char
            */

            #region Implicit Casting
            //int myInt = 9;
            //double myDouble = myInt;       // Automatic casting: int to double

            //Console.WriteLine(myInt);      // Outputs 9
            //Console.WriteLine(myDouble);   // Outputs 9
            #endregion

            #region Explicit Casting
            //double myDouble = 9.78;
            //int myInt = (int)myDouble;    // Manual casting: double to int

            //Console.WriteLine(myDouble);   // Outputs 9.78
            //Console.WriteLine(myInt);      // Outputs 9
            #endregion

            #region Type Conversion Methods
            //// It is also possible to convert data types explicitly by using built-in methods, such as Convert.
            //// ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):
            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            #endregion
            #endregion

            #region Get User Input
            //// Type your username and press enter
            //Console.WriteLine("Enter username:");

            //// Create a string variable and get user input from the keyboard and store it in the variable
            //string userName = Console.ReadLine();

            //// Print the value of the variable (userName), which will display the input value
            //Console.WriteLine("Username is: " + userName);

            //// User input and type casting
            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age);
            #endregion

            #region Operators
            /*
            * Operator          Name                                        Description Example 
            * +Addition         Adds together two values                    x + y
            * - Subtraction     Subtracts one value from another            x -y
            * * Multiplication  Multiplies two values                       x *y
            * / Division        Divides one value by another                x / y
            * % Modulus         Returns the division remainder              x % y
            * ++  Increment     Increases the value of a variable by 1      x++
            * --  Decrement     Decreases the value of a variable by 1      x--
            */

            //int sum1 = 100 + 50;        // 150 (100 + 50)
            //int sum2 = sum1 + 250;      // 400 (150 + 250)
            //int sum3 = sum2 + sum2;     // 800 (400 + 400)

            /* A list of all comparison operators:
                 Operator            Name                        Example 
                 ==                  Equal to                    x == y
                 !=                  Not equal                   x != y
                 >                   Greater than                x > y
                 <                   Less than                   x<y
                 >=                  Greater than or equal to    x >= y
                 <=                  Less than or equal to       x <= y
            */
            //int x = 5;
            //int y = 3;
            //Console.WriteLine(x > y); // returns True because 5 is greater than 3

            /*Operator        Name Description                                                        Example 
             *&&              Logical and Returns True if both statements are true                    x < 5 && x < 10
             *||              Logical or Returns True if one of the statements is true                x < 5 || x < 4
             *!               Logical not Reverse the result, returns False if the result is true     !(x < 5 && x < 10)
             */
            #endregion

            #region Math
            ////The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
            ////The Math.Max(x, y) method can be used to find the highest value of x and y:
            //Console.WriteLine(Math.Max(5, 10));
            ////The Math.Min(x,y) method can be used to find the lowest value of of x and y:
            //Console.WriteLine(Math.Min(5, 10));
            ////The Math.Sqrt(x) method returns the square root of x:
            //Console.WriteLine(Math.Sqrt(64));
            ////The Math.Abs(x) method returns the absolute (positive) value of x:
            //Console.WriteLine(Math.Abs(-4.7));
            ////Math.Round() rounds a number to the nearest whole number:
            //Console.WriteLine(Math.Round(9.99));

            #endregion
            Console.ReadKey();
        }
    }
}

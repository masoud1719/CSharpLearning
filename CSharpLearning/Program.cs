using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            #region Strings
            //// A string variable contains a collection of characters surrounded by double quotes:
            // string greeting = "Nice to meet you!";;

            //// String Length
            ////  length of a string can be found with the Length property
            // string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the txt string is: " + txt.Length);

            //// ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase.
            //string txt = "Hello World";
            //Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            //Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            //// String Trimming
            //// These methods will removes white spaces from the start or end or both direction
            //string txt = "            Hello World               ";
            //Console.WriteLine(txt.Trim());   // Outputs "Hello World"
            //Console.WriteLine(txt.TrimStart());   // Outputs "Hello World               "
            //Console.WriteLine(txt.TrimEnd());   // Outputs "            Hello World"

            #region String Concatenation
            //// The + operator can be used between strings to combine them. This is called concatenation:
            //string firstName = "John "; // Note that we have added a space after "John" to create a space between firstName and lastName on print.
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //Console.WriteLine(name);

            //// You can also use the string.Concat() method to concatenate two strings:
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = string.Concat(firstName," ", lastName);
            //Console.WriteLine(name);

            //// Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string.
            //// Note that you do not have to worry about spaces, like with concatenation:
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);
            #endregion

            #region  Special Characters
            ////Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
            // string txt = "We are the so-called "Vikings" from the north.";


            //// The solution to avoid this problem, is to use the backslash escape character.
            ////The backslash(\) escape character turns special characters into string characters:
            /*
             *      Escape character	Result	        Description
             *      \'	                '	            Single quote
             *      \"	                "	            Double quote
             *      \\	                \	            Backslash
             */

            //string txt1 = "We are the so-called \"Vikings\" from the north.";
            //string txt2 = "It\'s alright.";
            //string txt3 = "The character \\ is called backslash.";
            //Console.WriteLine(txt1);
            //Console.WriteLine(txt2);
            //Console.WriteLine(txt3);

            /* Other useful escape characters in C# are:
             *  Code	    Result	
             *  \n	        New Line	
             *  \t	        Tab	
             *  \b	        Backspace
             */
            //string txt1 = "line1\nline2";
            //string txt2 = "line1\tline1 after tab";
            //string txt3 = "line1\bline1 after back slash";
            //Console.WriteLine(txt1);
            //Console.WriteLine(txt2);
            //Console.WriteLine(txt3);

            #endregion

            #endregion

            #region  Conditions and If Statements and Switch
            /*
                * Less than: a < b
                *Less than or equal to: a <= b
                *Greater than: a > b
                *Greater than or equal to: a >= b
                *Equal to a == b
                *Not Equal to: a != b
            */

            /*
            * Use if to specify a block of code to be executed, if a specified condition is true
            *Use else to specify a block of code to be executed, if the same condition is false
            *Use else if to specify a new condition to test, if the first condition is false
            *Use switch to specify many alternative blocks of code to be executed
            */

            ////if (condition)
            ////{
            ////    // block of code to be executed if the condition is True
            ////}
            //// --------------------------------------------------------------------
            //if (20 > 18)
            //{
            //    Console.WriteLine("20 is greater than 18");
            //}
            //// --------------------------------------------------------------------
            ////if (condition)
            ////{
            ////    // block of code to be executed if the condition is True
            ////}
            ////else
            ////{
            ////    // block of code to be executed if the condition is False
            ////}
            //// --------------------------------------------------------------------
            //int time = 20;
            //if (time < 18)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            //// --------------------------------------------------------------------
            ////if (condition1)
            ////{
            ////    // block of code to be executed if condition1 is True
            ////}
            ////else if (condition2)
            ////{
            ////    // block of code to be executed if the condition1 is false and condition2 is True
            ////}
            ////else
            ////{
            ////    // block of code to be executed if the condition1 is false and condition2 is False
            ////}
            //// --------------------------------------------------------------------
            //int time = 22;
            //if (time < 10)
            //{
            //    Console.WriteLine("Good morning.");
            //}
            //else if (time < 20)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            //// Outputs "Good evening."
            //// --------------------------------------------------------------------
            //// variable = (condition) ? expressionTrue :  expressionFalse;
            //int time = 20;
            //if (time < 18)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            //int time = 20;
            //string result = (time < 18) ? "Good day." : "Good evening.";
            //Console.WriteLine(result);
            //// --------------------------------------------------------------------
            ////switch (expression)
            ////{
            ////    case x:
            ////        // code block
            ////        break;
            ////    case y:
            ////        // code block
            ////        break;
            ////    default:
            ////        // code block
            ////        break;
            ////}
            ////The switch expression is evaluated once
            ////The value of the expression is compared with the values of each case
            ////If there is a match, the associated block of code is executed
            ////The break and default keywords will be described later in this chapter
            //int day = 4;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            //// Outputs "Thursday" (day 4)
            #endregion

            #region Loops
            #region C# While Loop
            //// Loops can execute a block of code as long as a specified condition is reached.
            //// The while loop loops through a block of code as long as a specified condition is True:
            ////while (condition) 
            ////{
            /////   code block to be executed
            //// }
            //// Example :
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //// The do/while loop is a variant of the while loop. This loop will execute the code block once,
            //// before checking if the condition is true, then it will repeat the loop as long as the condition is true.
            //// do 
            ////{
            //// code block to be executed
            ////}
            ////while (condition) ;
            //// Example:
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 5);

            #endregion

            #region for Loop
            /*When you know exactly how many 
             * times you want to loop through a block of code, 
             * use the for loop instead of a while loop:
             */
            //// for (statement 1; statement 2; statement 3) 
            ////{
            //// // code block to be executed
            //// }
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            /*Example explained
             * Statement 1 sets a variable before the loop starts (int i = 0).
             * Statement 2 defines the condition for the loop to run (i must be less than 5). If the condition is true, the loop will start over again, if it is false, the loop will end.
             * Statement 3 increases a value (i++) each time the code block in the loop has been executed.
             */
            #region Nested Loops
            /*It is also possible to place a loop inside another loop. This is called a nested loop.
             * The "inner loop" will be executed one time for each iteration of the "outer loop":
             */
            //// Outer loop
            //for (int i = 1; i <= 2; ++i)
            //{
            //    Console.WriteLine("Outer: " + i);  // Executes 2 times

            //    // Inner loop
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            //    }
            //}
            #endregion

            #endregion

            #region C# Break and Continue
            /* You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.
              * The break statement can also be used to jump out of a loop.
              * This example jumps out of the loop when i is equal to 4:
              */
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            /*The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
             * This example skips the value of 4:
             */
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //// You can also use break and continue in while loops:
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //}
            //int i = 0;
            //while (i < 10)
            //{
            //    if (i == 4)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            #endregion

            #region Class Examples
            //for (int i =0; i < 10; i ++)
            //{
            //    if(i == 5)
            //    {
            //        continue;
            //    }
            //    else if (i == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //int n = 15;
            //do
            //{
            //    if (n == 5)
            //    {
            //        n += 1;
            //        continue;
            //    }
            //    else if (n == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(n);
            //    n += 1;
            //} while (n < 10);

            //Random r = new Random();
            //int rInt = r.Next(1, 10);

            //while (true)
            //{
            //    string userInputString = Console.ReadLine();
            //    int userInput = int.Parse(userInputString);
            //    if (userInput < rInt)
            //    {
            //        Console.WriteLine("Please select a bigger one");
            //    }
            //    else if (userInput > rInt)
            //    {
            //        Console.WriteLine("please select a smaller one");
            //    }
            //    else if (userInput == rInt)
            //    {
            //        Console.WriteLine("you won");
            //        break;
            //    }
            //}

            //DateTime d = new DateTime(2014,01,01);
            //DateTime d2 = d.AddDays(10);
            //TimeSpan d3 =d - d2;
            //Console.WriteLine(d);

            //double sum = 0;
            ////for (double i = 1; i < 101; i++)
            ////{
            ////    sum += i;
            ////}
            //int num = int.Parse(Console.ReadLine());
            //sum = ((num +1) * num) / 2;
            //Console.WriteLine(sum);
            //// O(n^2)

            //for (int i = 0; i < 10000; i++) 
            //{ 
            //    for(int j = 0; j < 10000; j++)
            //    {
            //        Console.WriteLine($"i={i}* j={j}");
            //    }
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    string star = string.Empty;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        star = star + "*";
            //    }
            //    Console.WriteLine(star);
            //}

            // * * * * *
            // * * * *
            // * * *
            // * * 
            // *
            #endregion
            #endregion

            #region Method
            /* A method is a block of code which only runs when it is called.
            *  You can pass data, known as parameters, into a method.
            *  Methods are used to perform certain actions, and they are also known as functions.
            *  Why use methods? To reuse code: define the code once, and use it many times.
            */
            ////Create a method inside the Program class:
            //    class Program
            //{
            //    static void MyMethod()
            //    {
            //        // code to be executed
            //    }
            //}
            //// MyMethod() is the name of the method
            //// void means that this method does not have a return value. You will learn more about return values later in this chapter
            //// Note: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.
            ////How to call a Method
            //int myRes = MySum(10, 20);

            //Console.WriteLine(myRes+50);
            //int  res = Math.Max(10, 20);

            //int res = MyMax(10, 20);
            //Console.WriteLine(res);

            //double avg = MyMethod(10, 20, 30);
            //Console.WriteLine(avg);

            //int[] arr = { 10, 20, 30, 200, 500, 700 };
            //double res = MyMethodArr(arr);
            //Console.WriteLine(res);

            //// Default Parameter
            //int res = MySum(10);
            //int res2 = MySum(10, 20);

            //// Method overloading
            //int res = MyMax(10,20);
            //double res2 = MyMax(30.5, 40.2);
            #endregion

            #region Class
            //// Create an object of Person class and define the public fields
            //Person teacher = new Person();
            //teacher.age = 20;
            //teacher.name = "test";
            //teacher.height = 171;

            //// Create another object of person class
            //Person worker = new Person();
            //Console.WriteLine(teacher.age);

            /// class Members
            //// Create an object of calculator class with default constructor
            //Calculator sonyCalculator = new Calculator();
            //sonyCalculator.brand = "Sony";
            //sonyCalculator.price = 500;
            //// Call the public method
            //int res = sonyCalculator.CalcSum(10, 20);
            //Console.WriteLine(res);


            /// Constructor
            //// Create an object of calculator class with our defined constructor
            //Person person2 = new Person(20, "test2", 171);
            //Console.WriteLine(person2._height);
            #region Access Modifiers
            /*
             * public	    The code is accessible for all classes
             * private	    The code is only accessible within the same class
             * protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
             * internal	    The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
             */
            ////Why Access Modifiers?
            ////To control the visibility of class members(the security level of each individual class and class member).
            ////To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.This is done by declaring fields as private. You will learn more about this in the next chapter.
            ////Note: By default, all members of a class are private if you don't specify an access modifier:
            ///If you declare a field with a private access modifier, it can only be accessed within the same class:
            //    class Car
            //{
            //    private string model = "Mustang";

            //    static void Main(string[] args)
            //    {
            //        Car myObj = new Car();
            //        Console.WriteLine(myObj.model);
            //    }
            //}
            #endregion

            #region Encapsulation
            //The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.To achieve this, you must:
            //declare fields/ variables as private
            //provide public get and set methods, through properties, to access and update the value of a private field
            #endregion

            #region Properties
            /*
             * You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
             * A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
             */
            //    class Person
            //{
            //    private string name; // field

            //    public string Name   // property
            //    {
            //        get { return name; }   // get method
            //        set { name = value; }  // set method
            //    }
            //}
            #region Automatic Properties (Short Hand)
            /*
             * C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.
             * The following example will produce the same result as the example above. The only difference is that there is less code:
             */
            //    class Person
            //{
            //    public string Name  // property
            //    { get; set; }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        Person myObj = new Person();
            //        myObj.Name = "Liam";
            //        Console.WriteLine(myObj.Name);
            //    }
            //}

            #endregion

            /* Why Encapsulation?
             * Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
             * Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
             * Flexible: the programmer can change one part of the code without affecting other parts
             * Increased security of data
             */
            #endregion
            #region Inheritance (Derived and Base Class)
            /*
             * In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:
             * Derived Class (child) - the class that inherits from another class
             * Base Class (parent) - the class being inherited from
             * To inherit from a class, use the : symbol.
             * In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
             */
            //    class Vehicle  // base class (parent) 
            //{
            //    public string brand = "Ford";  // Vehicle field
            //    public void honk()             // Vehicle method 
            //    {
            //        Console.WriteLine("Tuut, tuut!");
            //    }
            //}

            //class Car : Vehicle  // derived class (child)
            //{
            //    public string modelName = "Mustang";  // Car field
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        // Create a myCar object
            //        Car myCar = new Car();

            //        // Call the honk() method (From the Vehicle class) on the myCar object
            //        myCar.honk();

            //        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            //        Console.WriteLine(myCar.brand + " " + myCar.modelName);
            //    }
            //}
            #region  The sealed Keyword
            //// if you don't want other classes to inherit from a class, use the sealed keyword:
            //       sealed class Vehicle
            //      {
            //...
            //      }
            #endregion
            #region Polymorphism and Overriding Methods
            /*Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
             * Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.
             * For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals could be Pigs, Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):
             */
            //// Example 1 without virtual 
            //    class Animal  // Base class (parent) 
            //{
            //    public void animalSound()
            //    {
            //        Console.WriteLine("The animal makes a sound");
            //    }
            //}

            //class Pig : Animal  // Derived class (child) 
            //{
            //    public void animalSound()
            //    {
            //        Console.WriteLine("The pig says: wee wee");
            //    }
            //}

            //class Dog : Animal  // Derived class (child) 
            //{
            //    public void animalSound()
            //    {
            //        Console.WriteLine("The dog says: bow wow");
            //    }
            //}

            //class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        Animal myAnimal = new Animal();  // Create a Animal object
            //        Animal myPig = new Pig();  // Create a Pig object
            //        Animal myDog = new Dog();  // Create a Dog object

            //        myAnimal.animalSound();
            //        myPig.animalSound();
            //        myDog.animalSound();
            //    }
            //}

            //// Example 2 with virtual
                //    class Animal  // Base class (parent) 
                //{
                //    public virtual void animalSound()
                //    {
                //        Console.WriteLine("The animal makes a sound");
                //    }
                //}

                //class Pig : Animal  // Derived class (child) 
                //{
                //    public override void animalSound()
                //    {
                //        Console.WriteLine("The pig says: wee wee");
                //    }
                //}

                //class Dog : Animal  // Derived class (child) 
                //{
                //    public override void animalSound()
                //    {
                //        Console.WriteLine("The dog says: bow wow");
                //    }
                //}

                //class Program
                //{
                //    static void Main(string[] args)
                //    {
                //        Animal myAnimal = new Animal();  // Create a Animal object
                //        Animal myPig = new Pig();  // Create a Pig object
                //        Animal myDog = new Dog();  // Create a Dog object

                //        myAnimal.animalSound();
                //        myPig.animalSound();
                //        myDog.animalSound();
                //    }
                //}
        #endregion
        #endregion
        #endregion
        Console.ReadKey();
        }

        /// <summary>
        /// Method to get two int number and return the sum of them.
        /// </summary>
        /// <param name="num1"> The first number</param>
        /// <param name="num2"> The second number</param>
        /// <returns> sum of the two input numbers</returns>
        static int MySum(int num1, int num2)
        {
            int num3 = num1 + num2;
            return num3;
        }

        /// <summary>
        /// Method to find max number between two input number.
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <returns>Max of two input numbers</returns>
        static int MyMax(int num1, int num2)
        {
            if (num1 > num2) { return num1; }
            else { return num2; }
        }
        /// <summary>
        /// Method to find max number between two input number of type double
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <returns>Max of two input numbers of type double</returns>
        //static doubel MyMax(double num1, doubel num2)
        //{
        //    if (num1 > num2) { return num1; }
        //    else { return num2; }
        //}
        /// <summary>
        /// Find the avg of three number
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <param name="num3">The third number</param>
        /// <returns>average og these three number</returns>
        static double MyMethod(int num1, int num2, int num3)
        {
            double sum = num1 + num2 + num3;
            return sum / 3;
        }

        /// <summary>
        /// Find average of an existing array
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <returns>Avage of the input values in the array.</returns>
        static double MyMethodArr(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;

        }

        /// <summary>
        /// Method to find Min value of an existing array.
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <returns>min value of the array</returns>
        static double MyMin(int[] arr)
        {
            double min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Method with default parameter
        /// </summary>
        /// <param name="num1">num1</param>
        /// <param name="num2">num2</param>
        /// <returns>In case we haven't use num2 the first number will be return otherwise sum of the first and second number will be return.</returns>
        //static int MySum(int num1, int num2 = 0)
        //{
        //    return num1 + num2;
        //}
    }
}

using System.Drawing;
using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("please enter a number ");
            //int.TryParse(Console.ReadLine(), out int number);
            //Console.WriteLine("you entered " + number);	
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string stringName = "ahmed";		
            //if (int.TryParse(stringName, out int value))
            //{
            //	Console.WriteLine(value);
            //}

            //else
            //	Console.WriteLine("can't convert string char's to integer");
            //can't convert string char's to integer and if we use bool it will return false (0)

            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 12.27f , num2 = 67.17f  ;
            //float result = num2 * num1 ;
            //Console.WriteLine($"{num1} * {num2} =    { result}");
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            //بالاسم ده built in function  مش فاهم السؤال وعملت سيرش مفهمتش حاجه ومش متذكر اذا كانت البشمهندسه اديتنا 
            //ف هحضره في الوورك شوب ان شاء الله
            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 10;
            //int num2 = num1;
            //Console.WriteLine($"before modification \n" + "num1 = " +num1 + "\n" + "num2 = " +  num2);
            //num2 = 20;
            //Console.WriteLine($"after modification \n" + "num1 = " + num1 + "\n" + "num2 = " + num2);

            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //modifying mod1 = new modifying { name = "mohamed"};
            //modifying mod2 = mod1;
            //mod2.name = "pota";
            //Console.WriteLine(mod1.name);
            //Console.WriteLine(mod2.name);
            #endregion


            #region Q7 - Write C# program that take two string variables and print them as one variable 
            //string fname = "mohamed", lname = "ahmed";
            //string fullName = fname + " " + lname;
            //Console.WriteLine(fullName);

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //Console.Write("principalAmount ");
            //float.TryParse(Console.ReadLine() , out float principalAmount);
            //Console.Write("rate ");
            //int.TryParse(Console.ReadLine(), out int rate);

            //Console.Write("time ");
            //int.TryParse(Console.ReadLine(), out int time);
            //Console.Clear();
            //float interest = (principalAmount * rate * time) / 100;
            //Console.WriteLine( "your interest is "+ interest);

            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.Write("please enter your weight ");
            //float.TryParse(Console.ReadLine(), out float Weight);
            //Console.Write("please enter your Height ");
            //float.TryParse(Console.ReadLine(), out float Height);
            //float BMI = Weight / (Height * Height);
            //Console.WriteLine("your Body Mass Index is " + BMI);
            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"

            //Console.Write("please enter the temparature degree ");
            //int.TryParse(Console.ReadLine(), out var temp);

            //if (temp < 10)
            //{
            //    Console.WriteLine("too cold ");
            //}
            //else if (temp > 30)
            //{
            //    Console.WriteLine("too hot ");
            //}
            //else
            //    Console.WriteLine("just good ");

            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            //  Console.Write("Please Enter the date day ");
            //int.TryParse(Console.ReadLine() , out int dateDay);
            //  Console.Write("Please Enter the date month ");
            //  int.TryParse(Console.ReadLine(), out int dateMonth);
            //  Console.Write("Please Enter the date year ");
            //  int.TryParse(Console.ReadLine(), out int dateYear);
            //  Console.Clear();
            //  Console.WriteLine("Today’s date: " + dateDay + " / " + dateMonth + " / " + dateYear);
            //  Console.WriteLine("Today’s date: " + dateDay + " - " + dateMonth + " - " + dateYear);

            //  Console.WriteLine("Today’s date: " + dateDay + " , " + dateMonth + " , " + dateYear);



            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            //Console.Write("enter a number ");
            //int.TryParse(Console.ReadLine(), out var input1);
            //if (input1 % 3 == 0 && input1 % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else 
            //{
            //    Console.WriteLine("no");
            //}


            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            //Console.Write("please enter an integer number ");
            //int.TryParse(Console.ReadLine() , out int integer1);
            //if (integer1 < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //    Console.WriteLine("positive");
            #endregion


            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3
            //Console.Write("please enter the first number ");
            //int.TryParse(Console.ReadLine(), out int number1 );
            //Console.Write("please enter the second number ");
            //int.TryParse(Console.ReadLine(), out int number2);
            //Console.Write("please enter the third number ");
            //int.TryParse(Console.ReadLine(), out int number3);

            //int maxValue = number1;
            //int minValue = number1;

            //if (number2 > maxValue) maxValue = number2;
            //if (number2 < minValue) minValue = number2;

            //if (number3 > maxValue) maxValue = number3;
            //if (number3 < minValue) minValue = number3;

            //Console.Clear();
            //Console.WriteLine("the maximum value is " + maxValue);
            //Console.WriteLine("the minimum value is " + minValue);

            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("please inter an integer number ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(number + " is an even number");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is an odd number");
            //}

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            //  Console.Write("please enter a char ");
            //char userChar = Console.ReadLine() [0]; // ->[0] Get the first character
            //  if (userChar == 'a' || userChar == 'e' || userChar == 'i' || userChar == 'o' || userChar == 'u') 
            //  Console.WriteLine("vowel");
            //      else
            //  {
            //      Console.WriteLine("consonant");
            //  }

            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31
            //Console.Write("please enter the month number ");
            //    int.TryParse(Console.ReadLine(), out var monthNum);
            //int day = 0;
            //switch (monthNum)
            //{
            // case 1:
            // case 3:
            // case 5:
            // case 7:
            // case 8:
            // case 10:
            // case 12:
            //        day = 31;
            //        break;
            // case 4:
            // case 6:
            // case 9:
            // case 11:
            //        day = 30;
            //       break;  
            //  case 2:
            //        day = 29;
            //        break;

            //}
            //Console.WriteLine("the day number of the month " + monthNum + " is " + day);
            #endregion

        }
    }
}

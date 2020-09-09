using System;

namespace ConsoleAppFirstTime
{
    /*
    block comment


    */

    //inline comment

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, i like to code!");

            //CompereNumbers();//use method

            byte aByte = byte.MinValue; // 0 - 255
            short aShort = short.MinValue; // -32k - 32k
            int aInt = int.MinValue; // -2.1B - 2.1B
            long aLong = long.MinValue; // 9.2Q (9 223 372 036 854 775 808)

            float aFloat = float.MaxValue; // power of 38
            double aDouble = double.MaxValue; // power of 308
            decimal aDecimal = decimal.MaxValue; // 79 228 162 514 264 337 593 543 950 335


            // byte/short/int/long math
            Console.WriteLine(1/3);
            // 2 // 1 2 // 0 // 4 5 6 // error // 0 // = 0,3333 C# answer 0

            // float/double/decimal
            Console.WriteLine(1.0/3.0);

            char aChar = 'a'; // a symbol 'a' // ascii table number 97
            string aString = "abc";// string of symbols

            Console.WriteLine(aChar + 1);// 98
            Console.WriteLine(aString + 1);// abc1


            char anotherChar = '\x62';
            Console.WriteLine(anotherChar);

            //Alt key + arrow key up/down
        }

        //declaring a method
        static void CompereNumbers()
        {
            int numberOne;
            int numberTwo;
            
            Console.WriteLine("Pleace enter a number: ");
            numberOne = TextToNumber(Console.ReadLine());
            
            Console.WriteLine("Pleace enter a number: ");
            numberTwo = TextToNumber(Console.ReadLine());
            
            if(numberOne > numberTwo)
            {
                Console.WriteLine("Frist number was the biggest");
            }
            else
            {
                Console.WriteLine("Second number is the biggest");
            }
        }

        static int TextToNumber(string textNumber)
        {
            int number = 0;

            int.TryParse(textNumber, out number);

            return number;
        }
    }
}

/*
char userKeyPress = Console.ReadKey().KeyChar;

Console.WriteLine(userKeyPress);
*/

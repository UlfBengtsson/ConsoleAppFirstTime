using System;

namespace ConsoleAppFirstTime
{
    /*
    block comment


    */

    //inline comment

    //Alt key + arrow key up/down

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, i like to code!");

            //CompereNumbers();//use method

            bool runMenu = true;
            do
            {
                Console.Clear();
                Console.Write("---- menu -----\nEnter Loop to run the loop method.\nEnter quit to exit program.\nSelection: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Loop":
                        Loops();
                        break;

                    case "full name":
                        string firstName = AskUserFor("first name");
                        string lastName = AskUserFor("last name");

                        string fullName = CombineFirstAndLastNameIntoFullName(firstName, lastName);

                        Console.WriteLine("Your full name is: " + fullName);

                        break;

                    case "quit":
                        runMenu = false;
                        break;

                    default:
                        Console.WriteLine("not a valid input.");
                        break;
                }
                Console.WriteLine("press a key to continue.");
                Console.ReadKey();

            } while (runMenu);

        }

        static string AskUserFor(string whatFor)
        {
            Console.Write("Please enter " + whatFor + ": ");
            string userInput = Console.ReadLine();

            return userInput;
        }

        static string CombineFirstAndLastNameIntoFullName(string fristName, string lastName)
        {
            string fullName = fristName + " " + lastName;

            return fullName;
        }

        static void Loops()
        {
            //   init      compare  increment
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // 1: init will only run once
            // 2: compare will check very loop (even the first time before the code block as bin run for the first time)
            // 3: run code block
            // 4: increment after code block has bin run
            // 5: compare if its still true = run step 3 once more


            /*
            bool keepLooping = true;

            while(keepLooping)
            {
                Console.Write("What is your age?\nAge: ");
                //int age = int.Parse(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());

                keepLooping = false;

                if (age >= 18)
                {
                    Console.WriteLine("You may order a beer.");
                }
                else if(age > 2)
                {
                    Console.WriteLine("You can have a soda");
                }
                else if(age > 0)
                {
                    Console.WriteLine("want some baby milk?");
                }
                else
                {
                    Console.WriteLine("must type in a age grater then 0");
                    keepLooping = true;
                }

            }
            */
            bool keepLooping;

            do
            {
                keepLooping = false;
                Console.Write("What is your age?\nAge: ");
                //int age = int.Parse(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("You may order a beer.");
                }
                else if (age > 2)
                {
                    Console.WriteLine("You can have a soda");
                }
                else if (age > 0)
                {
                    Console.WriteLine("want some baby milk?");
                }
                else
                {
                    Console.WriteLine("must type in a age grater then 0");
                    keepLooping = true;
                }
            } while (keepLooping);
        }

        static void SymbolsEx()
        {

            char aChar = 'a'; // a symbol 'a' // ascii table number 97
            string aString = "abc";// string of symbols

            Console.WriteLine(aChar + " just a symbol and some text added thogether ");
            Console.WriteLine(aChar + 1);// 98 // remmember this
            Console.WriteLine(aString + 1);// abc1


            char anotherChar = '\x62';
            Console.WriteLine(anotherChar);

            for (int index = 0; index < aString.Length; index++)
            {
                Console.WriteLine(aString[index]);
                /*
                 string    "abc"
                 index      012
                */
            }
        }

        static void NumbersEx()
        {
            byte aByte = byte.MinValue; // 0 - 255
            short aShort = short.MinValue; // -32k - 32k
            int aInt = int.MinValue; // -2.1B - 2.1B
            long aLong = long.MinValue; // 9.2Q (9 223 372 036 854 775 808)

            float aFloat = float.MaxValue; // power of 38
            double aDouble = double.MaxValue; // power of 308
            decimal aDecimal = decimal.MaxValue; // 79 228 162 514 264 337 593 543 950 335


            // byte/short/int/long math
            Console.WriteLine(1 / 3);
            // 2 // 1 2 // 0 // 4 5 6 // error // 0 // = 0,3333 C# answer 0

            // float/double/decimal
            Console.WriteLine(1.0 / 3.0);
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

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

            CompereNumbers();//use method
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

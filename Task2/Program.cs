namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a user-specified program that inputs two numbers and prints the result of their multiplication. 
             * With this program, it is necessary to prompt the user for input numbers until both input numbers are known between 0 and 10. input of two numbers. 
             * If the entered population numbers have a range from 0 to 10, then the program displays the result of multiplication.
             * To organize consumers, an infinite while loop and a break statement
             */

            //Without infinite loop

            //Console.WriteLine("Input 1st number:");
            //var firstNumber = int.Parse(Console.ReadLine());
            //while (firstNumber<0 || firstNumber > 10)
            //{
            //    Console.WriteLine("1st number was not in range from 0 to 10, re-input number:");
            //    firstNumber = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Input 2nd number:");
            //var secondNumber = int.Parse(Console.ReadLine());
            //while (secondNumber < 0 || secondNumber > 10)
            //{
            //    Console.WriteLine("2nd number was not in range from 0 to 10, re-input number:");
            //    secondNumber = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"1st number is - {firstNumber}, 2nd number is - {secondNumber}, and their multiplication are - {firstNumber*secondNumber}");


            //With infinite loop
            int firstNumber;
            int secondNumber;
            while (true)
            {
                Console.WriteLine("Input 1st number:");
                firstNumber = int.Parse(Console.ReadLine());
                if (firstNumber >= 0 &&firstNumber <= 10)
                         break;
            }

            while (true)
            {
                Console.WriteLine("Input 2nd number:");
                secondNumber = int.Parse(Console.ReadLine());
                if (secondNumber >= 0 && secondNumber <= 10)
                    break;
            }

            Console.WriteLine($"1st number is - {firstNumber}, 2nd number is - {secondNumber}, and their multiplication are - {firstNumber * secondNumber}");



        }
    }
}
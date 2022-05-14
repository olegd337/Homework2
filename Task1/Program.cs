namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a console program where the user enters a number from the keyboard.
            //If the number is either 5 or 10, then the program outputs "The number is either 5 or 10". Otherwise, the program displays the message "Unknown number".

            Console.WriteLine("Enter number:");
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber == 5 || inputNumber == 10)
            {
                Console.WriteLine("The number is either 5 or 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }


        }
    }
}
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data on air temperature for ten days of November are stored in an array. Determine how many times the temperature dropped below -10 degrees.

            var tempretureArray = new int[10];
            for (int i = 0; i < tempretureArray.Length; i++)
            {
                Random rnd = new Random();
                tempretureArray[i] = rnd.Next(-50,50);
            }

            var temperatureDroppedBelowCounter = 0;
            foreach (var item in tempretureArray)
            {
                if (item <= -10)
                    temperatureDroppedBelowCounter++;
            }

            foreach (var item in tempretureArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Numbers of days below -10 degrees is {temperatureDroppedBelowCounter}");
        }
    }
}
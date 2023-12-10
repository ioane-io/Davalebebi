namespace TASK_N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            var sum = numbers.Sum();
            Console.WriteLine("Sum of Numbers:" + sum);
            var averageSum = sum / numbers.Length;
            Console.WriteLine("Average of numbers:" + averageSum);
            var maxNumber = numbers[0];
            var minNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine("Max Number is: " + maxNumber);
            Console.WriteLine("Min Number: " + minNumber);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine("divisibleByThree:" + numbers[i]);
                }
            }
        }
    }
}

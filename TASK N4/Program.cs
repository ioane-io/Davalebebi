namespace TASK_N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[5];
            Console.WriteLine("Enter first number:");
            numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            numbers[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            numbers[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            numbers[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fifth number:");
            numbers[4] = Convert.ToDouble(Console.ReadLine());
            var sumNumbers = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            Console.WriteLine("SUM of Numbers:" + sumNumbers);
            var averageNumbers = sumNumbers / 5;
            Console.WriteLine("Average of Numbers:" + averageNumbers);
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
            Console.WriteLine("Max Number: " + maxNumber);
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

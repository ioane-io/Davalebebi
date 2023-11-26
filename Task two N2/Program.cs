namespace Task_two_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Symbol ( +, -, *, / : ");
            var operation = Console.ReadLine();
            var sum = firstNumber + secondNumber;
            var subtraction = firstNumber - secondNumber;
            var multiply = firstNumber * secondNumber;
            var division = firstNumber / secondNumber;

            if (operation == "+")
            {
                Console.WriteLine(sum);
            }
            else if (operation == "-")
            {
                Console.WriteLine(subtraction);
            }
            else if (operation == "*")
            {
                Console.WriteLine(multiply);
            }
            else if (operation == "/")
            {
                Console.WriteLine(division);
            }
            else
            {
                Console.WriteLine("Please enter the correct operator");
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine(sum);
                    break;
                case "-":
                    Console.WriteLine(subtraction);
                    break;
                case "*":
                    Console.WriteLine(multiply);
                    break;
                case "/":
                    Console.WriteLine(division);
                    break;
                default: Console.WriteLine("operator is wrong");
                    break;
            }
        }
    }
}

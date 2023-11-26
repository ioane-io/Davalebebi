namespace Task_two_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Symbol ( +, -, *, / : ");
            var operation = Console.ReadLine();
            var sum = a + b; 
            var subtraction = a - b;
            var multiply = a * b; 
            var division = a / b;

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
            }
        }
    }
}

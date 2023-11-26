namespace Task_two_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pirveli Ricxvi: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Meore Ricxvi: ");
            var b = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Moqmedeba ( +, -, *, / : ");
            var symbol = Console.ReadLine();

            
            var sum = a + b; 
            var subtraction = a - b;
            var mult = a * b; 
            var div = a / b;

            if (symbol == "+")
            {
                Console.WriteLine(sum);
            }
            else if (symbol == "-")
            {
                Console.WriteLine(subtraction);
            }
            else if (symbol == "*")
            {
                Console.WriteLine(mult);
            }
            else if (symbol == "/")
            {
                Console.WriteLine(div);
            }
            else
            {
                Console.WriteLine("Please enter the correct operator");
            }



            switch (symbol)
            {
                case "+":               
                    Console.WriteLine(sum);
                    break;

                case "-":
                    Console.WriteLine(subtraction);
                    break;

                case "*":
                    Console.WriteLine(mult);
                    break;

                case "/":
                    Console.WriteLine(div);
                    break;
            }

           

        }
    }
}

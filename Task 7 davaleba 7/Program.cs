namespace Task_7_davaleba_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Nino", Age = 30, City = "Tbilisi" },
            new Person { Name = "David", Age = 22, City = "Batumi" },
            new Person { Name = "Tamar", Age = 28, City = "Tbilisi" },
            new Person { Name = "Mary", Age = 25, City = "Batumi" },
            new Person { Name = "Giorgi", Age = 35, City = "Tbilisi" }
        };
            var result1 = people
                .Where(person => person.Age > 25)
                .OrderByDescending(person => person.Age);
            Console.WriteLine("People over 25, by descending :");
            foreach (var person in result1)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old");
            }
            var result2 = people
                .Where(person => person.City == "Tbilisi")
                .OrderBy(person => person.Name);
            Console.WriteLine("\n People From Tbilisi, by alphabet:");
            foreach (var person in result2)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old");
            }
            var result3 = people
                .Where(person => person.Age > 25)
                .Select(person => person.Name)
                .ToList();
            Console.WriteLine("\n people over 25:");
            foreach (var name in result3)
            {
                Console.WriteLine(name);
            }
            var averageAge = people
                .Where(person => person.Age > 25)
                .Average(person => person.Age);

            Console.WriteLine($"\n Average age over 25: {averageAge:F2} years");
            var numberOfPeopleInTbilisi = people
                .Count(person => person.City == "Tbilisi");
            Console.WriteLine($"\n Number of people From Tbilisi: {numberOfPeopleInTbilisi}");

        }
    }
}
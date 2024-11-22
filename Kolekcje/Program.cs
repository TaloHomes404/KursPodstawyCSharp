using Biblioteka;

namespace Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tworzenie list, dictionary, LINQ, Queue, Stack
            //Implementacja prostych algorytmów przeszukiwania list
            //Zasady działania struktur danych FIFO, LIFO

            List<string> names = new List<string>();
            List<double> prices = new List<double>();
            names.Add("Albert");
            prices.Add(2.99);
            prices.Add(49.99);

            List<int> numbers = new List<int>() { 5, 100, 2, 6, 19, 32, 510 };


            Console.WriteLine("Add number: ");
            string inputText = Console.ReadLine();
            int value = int.Parse(inputText);
            numbers.Add(value);

            //Tworzymy liste obiektów klasy Person

            static List<Person> GetEmployees()
            {
                List<Person> employees = new List<Person>()
            {
                new Person(21, "Joe", "Smith", new DateTime(2001,10,1), "12345678"),
                new Person(41, "Liam", "West", new DateTime(1995,2,17), "634262526"),
                new Person(21, "George", "Smith", new DateTime(2000,3,9), "52674246"),
                new Person(21, "Noah", "East", new DateTime(1991,1,10), "24735528"),
                new Person(21, "Bill", "Kowalski", new DateTime(1984,5,21), "25623614"),
            };
                return employees;
            }

            //Tworzymy liste pracowników
            List<Person> employees = GetEmployees();

            //Warunek do LINQ który wypisze pracownika urodzonego po 2000r.
            //bool EmployeeIsYoung(Person worker)
            //{
            //    return worker.GetBirthDate() > new DateTime(2000, 1, 1);
            //} zamiast tego warunku uzyjemy wyrazenia lambda

            //Tworzymy liste pracowników młodych z pomocą LINQ
            List<Person> youngEmployees = employees.Where(e => e.GetBirthDate() > new DateTime(2000, 1, 1)).ToList();
            Console.WriteLine("Number of young workes (born after 2000): " + youngEmployees);
            //Pobieramy listę numerów telefonów pracowników

        }

    }
}
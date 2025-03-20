using System.Drawing;

namespace Lab3CSharp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter option 1-2: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 2;

            while (!isValid)
            {
                Console.Write("Please enter a valid option. Enter option 1-2: ");
                isValid = int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 2;
            }

            switch (option)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
            }
        }

        private static void Task1()
        {
            Trapezoid[] trapezoids = [
                new(6, 5, 1),
                new(Color.Red, 3, 3, 3),
                new(Color.Green, 5, 5, 3),
                new(Color.Blue, 10, 6, 4)
            ];

            int squareCount = 0;

            foreach (Trapezoid trapezoid in trapezoids)
            {
                trapezoid.Display();
                Console.WriteLine($"Trapezoid perimeter = {trapezoid.Perimeter():.00}");
                Console.WriteLine($"Trapezoid area = {trapezoid.Area():.00}");

                if (trapezoid.IsSquare())
                {
                    Console.WriteLine("Trapezoid is a square\n");
                    squareCount++;
                }
                else
                {
                    Console.WriteLine("Trapezoid isn't a square\n");
                }
            }

            Console.WriteLine($"Found {squareCount} squares");
        }

        private static void Task2()
        {
            static void FillArray(Person[] people)
            {
                people[0] = new Person("John", 50);
                people[1] = new Worker("Emma", 25, "Technician");
                people[2] = new Employee("Robert", 40, "Manager", "ABC Corp", 1000);
                people[3] = new Engineer("Alice", 30, "Software Engineer", "TechCorp", 3000, "Software");
                people[4] = new Engineer("Mark", 35, "Mechanical Engineer", "AutoCorp", 4000, "Mechanical");
            }

            Person[] people = new Person[5];
            FillArray(people);

            people = [.. people.OrderBy(p => p.Age)];

            Console.WriteLine("Sorted list by Age:");

            foreach (var person in people)
            {
                Console.WriteLine();
                person.Show();
            }
        }
    }
}

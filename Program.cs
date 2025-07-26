using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var events = new System.Collections.Generic.Dictionary<string, DateTime>();

            Console.WriteLine("Enter 5 events (Name and Date in MM/DD/YYYY):");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Event {i} Name: ");
                string name = Console.ReadLine();

                Console.Write($"Date (MM/DD/YYYY): ");
                DateTime date;
                while (!DateTime.TryParse(Console.ReadLine(), out date))
                    Console.Write("Invalid format. Try again (MM/DD/YYYY): ");

                while (events.ContainsValue(date))
                {
                    Console.Write("Date already exists. Enter new date: ");
                    DateTime.TryParse(Console.ReadLine(), out date);
                }
                events.Add(name, date);
            }
            Console.WriteLine("\nSorted Events:");
            foreach (var e in events.OrderBy(x => x.Value))
                Console.WriteLine($"{e.Value:MM/dd/yyyy}: {e.Key}");
        }
    }
}
            
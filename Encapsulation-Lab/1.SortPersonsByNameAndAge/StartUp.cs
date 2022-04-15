using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0],data[1],int.Parse(data[2]));
                persons.Add(person);
            }

            persons.OrderBy(x => x.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
